using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu_trainer
{
    public partial class UpdaterForm : Form
    {
        public bool DoNotCheckForUpdates = false;
        public UpdaterForm(string releaseNotes)
        {
            InitializeComponent();
            releaseNotesTextBox.Text = releaseNotes;
        }

        private void doNotCheckForUpdatesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DoNotCheckForUpdates = doNotCheckForUpdatesCheckBox.Checked;
        }
    }
}
