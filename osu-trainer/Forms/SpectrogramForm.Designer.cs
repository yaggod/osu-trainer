namespace osu_trainer.Forms
{
    partial class SpectrogramForm
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
            this.components = new System.ComponentModel.Container();
            this.speedPlot = new ScottPlot.FormsPlot();
            this.SuspendLayout();
            // 
            // speedPlot
            // 
            this.speedPlot.Location = new System.Drawing.Point(12, 12);
            this.speedPlot.Name = "speedPlot";
            this.speedPlot.Size = new System.Drawing.Size(500, 350);
            this.speedPlot.TabIndex = 0;
            // 
            // SpectrogramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 377);
            this.Controls.Add(this.speedPlot);
            this.Name = "SpectrogramForm";
            this.Text = "SpectrogramForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ScottPlot.FormsPlot speedPlot;
    }
}