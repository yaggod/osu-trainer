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
        public static void GenerateAudioFile(string inFile, string outFile, decimal effectiveMultiplier, bool changePitch = false, bool preDT = false, bool highQuality = false)
        {
            decimal DTCompensatedMultiplier = effectiveMultiplier / 1.5M;

            string temp1 = Path.Combine(Guid.NewGuid().ToString() + ".mp3"); // audio copy
            string temp2 = Path.Combine(Guid.NewGuid().ToString() + ".wav"); // decoded wav
            string temp3 = Path.Combine(Guid.NewGuid().ToString() + ".wav"); // stretched file

            File.Copy(inFile, temp1);

            // mp3 => wav
            using (Mp3FileReader mp3 = new Mp3FileReader(temp1))
            using (WaveStream wav = WaveFormatConversionStream.CreatePcmStream(mp3))
                WaveFileWriter.CreateWaveFile(temp2, wav);


            // stretch (or speed up) wav
            string quick = highQuality ? "" : "-quick";
            string naa = highQuality ? "" : "-naa";

            decimal multiplier = preDT ? DTCompensatedMultiplier : effectiveMultiplier;
            string tempo = $"-tempo={(multiplier - 1) * 100}";

            decimal cents = (decimal)(1200.0 * Math.Log((double)effectiveMultiplier) / Math.Log(2));
            decimal semitones = cents / 100.0M;
            string pitch = changePitch ? $"-pitch={semitones}" : "";

            Process soundstretch = new Process();
            soundstretch.StartInfo.FileName = Path.Combine("binaries", "soundstretch.exe");
            soundstretch.StartInfo.Arguments = $"\"{temp2}\" \"{temp3}\" {quick} {naa} {tempo} {pitch}";
            Console.WriteLine(soundstretch.StartInfo.Arguments);
            soundstretch.StartInfo.UseShellExecute = false;
            soundstretch.StartInfo.CreateNoWindow = true;
            soundstretch.Start();
            soundstretch.WaitForExit();


            // wav => mp3
            if (File.Exists(outFile))
                File.Delete(outFile);
            using (var wav = new WaveFileReader(temp3))
            using (var mp3 = new LameMP3FileWriter(outFile, wav.WaveFormat, highQuality ? LAMEPreset.STANDARD : LAMEPreset.MEDIUM))
                wav.CopyTo(mp3);


            // Clean up
            try
            {
                File.Delete(temp1);
                File.Delete(temp2);
                File.Delete(temp3);
            }
            catch { } // don't shit the bed if we can't delete temp files
        }
    }
}