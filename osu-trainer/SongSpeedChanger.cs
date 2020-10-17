using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using NAudio.Wave;
using NAudio.Lame; 

namespace osu_trainer
{
    internal class SongSpeedChanger
    {
        public static void GenerateAudioFile(string inFile, string outFile, decimal multiplier, bool changePitch = false, bool preDT = false)
        {
            decimal compensatedMultiplier = multiplier / 1.5M;

            string temp1 = JunUtils.GetTempFilename("mp3"); // audio copy
            string temp2 = JunUtils.GetTempFilename("wav"); // decoded wav
            string temp3 = JunUtils.GetTempFilename("wav"); // stretched file
            string temp4 = JunUtils.GetTempFilename("mp3"); // encoded mp3

            // TODO: try catch
            File.Copy(inFile, temp1);

            // mp3 => wav
            using (Mp3FileReader mp3 = new Mp3FileReader(temp1))
            using (WaveStream wav = WaveFormatConversionStream.CreatePcmStream(mp3))
            {
                WaveFileWriter.CreateWaveFile(temp2, wav);
            }


            // stretch (or speed up) wav
            decimal selectedMultiplier = (preDT ? compensatedMultiplier : multiplier);
            decimal tempo = (selectedMultiplier - 1) * 100;

            decimal cents = (decimal)(1200.0 * Math.Log((double)multiplier) / Math.Log(2));
            decimal semitones = cents / 100.0M;
            Process soundstretch = new Process();
            soundstretch.StartInfo.FileName = Path.Combine("binaries", "soundstretch.exe");
            if (changePitch)
                soundstretch.StartInfo.Arguments = $"\"{temp2}\" \"{temp3}\" -quick -naa -tempo={tempo} -pitch={semitones}";
            else
                soundstretch.StartInfo.Arguments = $"\"{temp2}\" \"{temp3}\" -quick -naa -tempo={tempo}";
            Console.WriteLine(soundstretch.StartInfo.Arguments);
            soundstretch.StartInfo.UseShellExecute = false;
            soundstretch.StartInfo.CreateNoWindow = true;
            soundstretch.Start();
            soundstretch.WaitForExit();

            // wav => mp3
            using (var wav = new WaveFileReader(temp3))
            using (var mp3 = new LameMP3FileWriter(temp4, wav.WaveFormat, LAMEPreset.STANDARD))
            {
                wav.CopyTo(mp3);
            }

            if (File.Exists(outFile))
                File.Delete(outFile);
            File.Copy(temp4, outFile);

            // Clean up
            File.Delete(temp1);
            File.Delete(temp2);
            File.Delete(temp3);
            File.Delete(temp4);
        }
    }
}