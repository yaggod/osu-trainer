using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu_trainer
{
    public partial class SongsFolderForm : Form
    {
        // This is to be returned upon closing this form
        public string SongsFolder; 
        public SongsFolderForm(string folder)
        {
            InitializeComponent();
            songsFolderTextBox.Text = folder;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            SongsFolder = songsFolderTextBox.Text;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                songsFolderTextBox.Text = dialog.FileName;
                SongsFolder = dialog.FileName;
            }
        }
    }
}
