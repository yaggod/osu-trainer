using FsBeatmapProcessor;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu_trainer.Forms
{
    public partial class SpectrogramForm : Form
    {
        // singleton instance
        public static SpectrogramForm Instance = null;

        private BeatmapEditor Editor;
        public SpectrogramForm(BeatmapEditor editor)
        {
            InitializeComponent();
            Editor = editor;
            Size = new Size(Screen.PrimaryScreen.Bounds.Width, Size.Height);
            Editor.BeatmapModified += UpdateSpectrogram;
            Editor.BeatmapSwitched += UpdateSpectrogram;
            UpdateSpectrogram(this, EventArgs.Empty);
            Instance = this;
        }

        public void UpdateSpectrogram(object sender, EventArgs e)
        {
            if (Editor.OriginalBeatmap == null)
                return;
            if (Editor.NewBeatmap == null)
                return;

            // TODO: Get osu trainer beatmap if it is currently selected

            // Plot speed spectrogram of original beatmap
            // points => (time, kps)
            //var (times, originalKps) = GetSpeedSpectrogramData(Editor.OriginalBeatmap);
            ////var newKps = GetSpeedSpectrogramData(Editor.NewBeatmap).Item2;
            //speedPlot.plt.Clear();
            //speedPlot.plt.XAxis.Ticks(false, false);
            //speedPlot.plt.YAxis.Ticks(false, false);
            //speedPlot.plt.Frame(false);
            //speedPlot.plt.Style(Style.Blue2);
            //speedPlot.plt.YLabel("KPS");
            //float w = 0.05f;
            ////speedPlot.plt.PlotVSpan(y1: 13.33 - w, y2: 13.33 + w, label: "200 bpm streams");
            //speedPlot.plt.PlotScatter(
            //    times, originalKps,
            //    lineWidth: 0,
            //    color: Color.FromArgb(15, 255, 85, 85),
            //    markerSize: 14,
            //    markerShape: MarkerShape.filledCircle
            //);
            //speedPlot.plt.Axis(null, null, 0, null);
            //speedPlot.plt.TightenLayout(padding: 0);
            //speedPlot.Render();
        }
        public (double[], double[]) GetSpeedSpectrogramData(Beatmap map)
        {
            var hitTimes = map.HitObjectTimes.ToList();
            var times = new double[hitTimes.Count];
            var kps = new double[hitTimes.Count];

            if (hitTimes.Count < 2)
                return (times, kps); // garbage

            // first note: use distance to second note
            times[0] = hitTimes[0] / 1000.0;
            kps[0] = 1000.0 / (hitTimes[1] - hitTimes[0]);

            for (int i = 1; i < hitTimes.Count - 1; i++)
            {
                // use minimum neighbouring distance
                double previousTime = hitTimes[i - 1];
                double hitTime = hitTimes[i];
                double nextTime = hitTimes[i + 1];
                times[i] = hitTime / 1000.0;
                kps[i] = 1000.0 / Math.Min(hitTime - previousTime, nextTime - hitTime);
            }

            // last note: use distance to second last note
            times[hitTimes.Count - 1] = hitTimes[hitTimes.Count - 1] / 1000.0;
            kps[hitTimes.Count - 1] = 1000.0 / (hitTimes[hitTimes.Count - 1] - hitTimes[hitTimes.Count - 2]);

            kps = QuantizeRhythm(kps, map.Bpms.ToArray());


            //for (int i = 1; i < hitTimes.Count; i++)
            //{
            //    // Need to change kps algorithm
            //    // Proposal:
            //    double hitTime = hitTimes[i];
            //    double previousHitTime = hitTimes[i - 1];
            //    times[i - 1] = hitTime / 1000.0;
            //    kps[i - 1] = 1000.0 / (hitTime - previousHitTime);
            //    // Note: There is a ±1ms variance for (hitTime - previousHitTime) for notes of the same rhythm.
            //    // This is due to ms precision issues
            //    // Should use an algorithm to quantize these points to the same value
            //    // Proposal:
            //}
            return (times, kps);
        }
        // 1. Extract all unique bpms from beatmap timing points
        // 2. For each bpm, create bins corresponding to 1/1, 1/2, and 1/4 notes, spanning ±2ms
        // 3. Quantize all points lying in these bins
        public double[] QuantizeRhythm(double[] kps, decimal[] bpms)
        {
            double[] ret = new double[kps.Length];
            var quantizedKpsLevels = new List<double>();
            foreach (decimal bpm in bpms)
            {
                quantizedKpsLevels.Add((double)(bpm * 1) / 60.0); // 1/1
                quantizedKpsLevels.Add((double)(bpm * 2) / 60.0); // 1/2
                quantizedKpsLevels.Add((double)(bpm * 4) / 60.0); // 1/4
            }
            for (int i = 0; i < kps.Length; i++)
            {
                ret[i] = kps[i];
                foreach (double q_kps in quantizedKpsLevels)
                {
                    double x_ms = 1000.0 / kps[i];
                    double q_ms = 1000.0 / q_kps;
                    if (Math.Abs(q_ms - x_ms) <= 2)
                    {
                        ret[i] = q_kps; // quantize
                        break;
                    }
                }
            }
            return ret;
        }

        private void SpectrogramForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Instance = null;
        }
    }
}
