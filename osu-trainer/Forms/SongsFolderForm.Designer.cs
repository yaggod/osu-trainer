namespace osu_trainer
{
    partial class SongsFolderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.confirmButton = new osu_trainer.Controls.OsuButton();
            this.songsFolderTextBox = new System.Windows.Forms.MaskedTextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmButton.BrightnessRange = 0.01F;
            this.confirmButton.Color = System.Drawing.Color.DodgerBlue;
            this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.Location = new System.Drawing.Point(339, 63);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Progress = 0F;
            this.confirmButton.ProgressColor = System.Drawing.Color.Transparent;
            this.confirmButton.Size = new System.Drawing.Size(102, 23);
            this.confirmButton.Subtext = "";
            this.confirmButton.SubtextColor = System.Drawing.Color.Empty;
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.TextYOffset = 0;
            this.confirmButton.TriangleCount = 30;
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // songsFolderTextBox
            // 
            this.songsFolderTextBox.Location = new System.Drawing.Point(12, 32);
            this.songsFolderTextBox.Name = "songsFolderTextBox";
            this.songsFolderTextBox.Size = new System.Drawing.Size(348, 20);
            this.songsFolderTextBox.TabIndex = 3;
            this.songsFolderTextBox.Text = "C:\\Program Files\\osu!\\Songs";
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(366, 29);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 25);
            this.browseButton.TabIndex = 5;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "You normally don\'t have to change this unless you store your songs in a special l" +
    "ocation.";
            // 
            // SongsFolderForm
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 98);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.songsFolderTextBox);
            this.Controls.Add(this.confirmButton);
            this.Name = "SongsFolderForm";
            this.ShowIcon = false;
            this.Text = "Songs Folder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.OsuButton confirmButton;
        private System.Windows.Forms.MaskedTextBox songsFolderTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label1;
    }
}