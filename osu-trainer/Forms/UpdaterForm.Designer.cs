namespace osu_trainer
{
    partial class UpdaterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.doNotCheckForUpdatesCheckBox = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.releaseNotesTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 28);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Release Notes:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.updateButton);
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.doNotCheckForUpdatesCheckBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 36);
            this.panel2.TabIndex = 1;
            // 
            // updateButton
            // 
            this.updateButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.updateButton.Location = new System.Drawing.Point(472, 6);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(391, 6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // doNotCheckForUpdatesCheckBox
            // 
            this.doNotCheckForUpdatesCheckBox.AutoSize = true;
            this.doNotCheckForUpdatesCheckBox.Location = new System.Drawing.Point(15, 10);
            this.doNotCheckForUpdatesCheckBox.Name = "doNotCheckForUpdatesCheckBox";
            this.doNotCheckForUpdatesCheckBox.Size = new System.Drawing.Size(147, 17);
            this.doNotCheckForUpdatesCheckBox.TabIndex = 4;
            this.doNotCheckForUpdatesCheckBox.Text = "Do not check for updates";
            this.doNotCheckForUpdatesCheckBox.UseVisualStyleBackColor = true;
            this.doNotCheckForUpdatesCheckBox.CheckedChanged += new System.EventHandler(this.doNotCheckForUpdatesCheckBox_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.releaseNotesTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.panel3.Size = new System.Drawing.Size(559, 316);
            this.panel3.TabIndex = 2;
            // 
            // releaseNotesTextBox
            // 
            this.releaseNotesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.releaseNotesTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseNotesTextBox.Location = new System.Drawing.Point(13, 0);
            this.releaseNotesTextBox.Name = "releaseNotesTextBox";
            this.releaseNotesTextBox.Size = new System.Drawing.Size(533, 316);
            this.releaseNotesTextBox.TabIndex = 0;
            this.releaseNotesTextBox.Text = "";
            // 
            // UpdaterForm
            // 
            this.AcceptButton = this.updateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(559, 380);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UpdaterForm";
            this.ShowIcon = false;
            this.Text = "Update Available!";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox releaseNotesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox doNotCheckForUpdatesCheckBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cancelButton;
    }
}