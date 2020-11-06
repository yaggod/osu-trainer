using FsBeatmapProcessor;
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
        private BeatmapEditor Editor;
        public SpectrogramForm(BeatmapEditor editor)
        {
            InitializeComponent();
            Editor = editor;
            // need to register BeatmapSwitched and BeatmapModified events
            Editor.BeatmapModified += UpdateSpectrogram;
            Editor.BeatmapSwitched += UpdateSpectrogram;
            UpdateSpectrogram(this, EventArgs.Empty);
        }

        public void UpdateSpectrogram(object sender, EventArgs e)
        {
            if (Editor.OriginalBeatmap == null)
                return;
            if (Editor.NewBeatmap == null)
                return;

            // Plot speed spectrogram of original beatmap
            // points => (time, kps)
            var (times, originalKps) = GetSpeedSpectrogramData(Editor.OriginalBeatmap);
            //var newKps = GetSpeedSpectrogramData(Editor.NewBeatmap).Item2;
            speedPlot.plt.Clear();
            speedPlot.plt.Title("Speed Spectrogram");
            speedPlot.plt.XLabel("Time (s)");
            speedPlot.plt.YLabel("KPS");
            float w = 0.05f;
            speedPlot.plt.PlotVSpan(y1: 17.33 - w, y2: 17.33 + w, label: "260 bpm streams");
            speedPlot.plt.PlotVSpan(y1: 16.00 - w, y2: 16.00 + w, label: "240 bpm streams");
            speedPlot.plt.PlotVSpan(y1: 14.67 - w, y2: 14.67 + w, label: "220 bpm streams");
            speedPlot.plt.PlotVSpan(y1: 13.33 - w, y2: 13.33 + w, label: "200 bpm streams");
            speedPlot.plt.PlotVSpan(y1: 12.00 - w, y2: 12.00 + w, label: "180 bpm streams");
            speedPlot.plt.PlotScatter(times, originalKps, lineWidth: 0, color: Color.Red, markerSize: 3);
            //speedPlot.plt.PlotScatter(times, newKps, lineWidth: 0, color: Color.Red);
            speedPlot.plt.Axis(null, null, 0, 20);
            speedPlot.Render();
        }
        public (double[], double[]) GetSpeedSpectrogramData(Beatmap map)
        {
            var hitTimes = Editor.OriginalBeatmap.HitObjectTimes.ToList();
            var times = new double[hitTimes.Count - 1];
            var kps = new double[hitTimes.Count - 1];
            for (int i = 1; i < hitTimes.Count; i++)
            {
                // Need to change kps algorithm
                // Proposal:
                // For each note,
                //    If first note, use distance to next note
                //    If last note, use distance from previous note
                //    Else, use minimum neighbouring distance
                double hitTime = hitTimes[i];
                double previousHitTime = hitTimes[i - 1];
                times[i - 1] = hitTime / 1000.0;
                kps[i - 1] = 1000.0f / (hitTime - previousHitTime);
                // Note: There is a ±1ms variance for (hitTime - previousHitTime) for notes of the same rhythm.
                // This is due to ms precision issues
                // Should use an algorithm to quantize these points to the same value
                // Proposal:
                // 1. Extract all unique bpms from beatmap timing points
                // 2. For each bpm, create bins corresponding to 1/1, 1/2, and 1/4 notes, spanning ±2ms
                // 3. Quantize all points lying in these bins
            }
            return (times, kps);
        }

        public void LloydMaxCluster3()
        {
        }
    }
}
