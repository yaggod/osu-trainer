namespace osu_trainer.Forms
{
    partial class HotkeyForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pressAKeyLabel5 = new System.Windows.Forms.Label();
            this.pressAKeyLabel4 = new System.Windows.Forms.Label();
            this.pressAKeyLabel3 = new System.Windows.Forms.Label();
            this.pressAKeyLabel2 = new System.Windows.Forms.Label();
            this.pressAKeyLabel1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.Location = new System.Drawing.Point(268, 1);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(52, 30);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "✕";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.titlePanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 217);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // titlePanel
            // 
            this.titlePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.titlePanel.Controls.Add(this.closeButton);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(321, 30);
            this.titlePanel.TabIndex = 0;
            this.titlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.titlePanel_Paint);
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            this.titlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseUp);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pressAKeyLabel5);
            this.panel2.Controls.Add(this.pressAKeyLabel4);
            this.panel2.Controls.Add(this.pressAKeyLabel3);
            this.panel2.Controls.Add(this.pressAKeyLabel2);
            this.panel2.Controls.Add(this.pressAKeyLabel1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.SpeedLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 187);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(140)))));
            this.button5.Location = new System.Drawing.Point(209, 142);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 28);
            this.button5.TabIndex = 25;
            this.button5.Text = "A";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(140)))));
            this.button4.Location = new System.Drawing.Point(209, 110);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 28);
            this.button4.TabIndex = 25;
            this.button4.Text = "F";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(140)))));
            this.button3.Location = new System.Drawing.Point(209, 78);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 28);
            this.button3.TabIndex = 25;
            this.button3.Text = "D";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(140)))));
            this.button2.Location = new System.Drawing.Point(209, 46);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 28);
            this.button2.TabIndex = 25;
            this.button2.Text = "S";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(140)))));
            this.button1.Location = new System.Drawing.Point(209, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(154)))), ((int)(((byte)(233)))));
            this.label4.Location = new System.Drawing.Point(14, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label4.MinimumSize = new System.Drawing.Size(75, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Generate Map";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(154)))), ((int)(((byte)(233)))));
            this.label3.Location = new System.Drawing.Point(14, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.MinimumSize = new System.Drawing.Size(75, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Execute Profile 4";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(154)))), ((int)(((byte)(233)))));
            this.label2.Location = new System.Drawing.Point(14, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.MinimumSize = new System.Drawing.Size(75, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Execute Profile 3";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(154)))), ((int)(((byte)(233)))));
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.MinimumSize = new System.Drawing.Size(75, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Execute Profile 2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(134)))));
            this.label9.Location = new System.Drawing.Point(129, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label9.MinimumSize = new System.Drawing.Size(75, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label9.Size = new System.Drawing.Size(93, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "Ctrl + Shift + ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(134)))));
            this.label8.Location = new System.Drawing.Point(134, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label8.MinimumSize = new System.Drawing.Size(75, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label8.Size = new System.Drawing.Size(88, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "Alt + Shift + ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(134)))));
            this.label7.Location = new System.Drawing.Point(134, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label7.MinimumSize = new System.Drawing.Size(75, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label7.Size = new System.Drawing.Size(88, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "Alt + Shift + ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(134)))));
            this.label6.Location = new System.Drawing.Point(134, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label6.MinimumSize = new System.Drawing.Size(75, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Alt + Shift + ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pressAKeyLabel5
            // 
            this.pressAKeyLabel5.AutoSize = true;
            this.pressAKeyLabel5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressAKeyLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(140)))));
            this.pressAKeyLabel5.Location = new System.Drawing.Point(233, 145);
            this.pressAKeyLabel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pressAKeyLabel5.MinimumSize = new System.Drawing.Size(75, 0);
            this.pressAKeyLabel5.Name = "pressAKeyLabel5";
            this.pressAKeyLabel5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pressAKeyLabel5.Size = new System.Drawing.Size(78, 22);
            this.pressAKeyLabel5.TabIndex = 24;
            this.pressAKeyLabel5.Text = "press a key...";
            this.pressAKeyLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pressAKeyLabel4
            // 
            this.pressAKeyLabel4.AutoSize = true;
            this.pressAKeyLabel4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressAKeyLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(140)))));
            this.pressAKeyLabel4.Location = new System.Drawing.Point(233, 113);
            this.pressAKeyLabel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pressAKeyLabel4.MinimumSize = new System.Drawing.Size(75, 0);
            this.pressAKeyLabel4.Name = "pressAKeyLabel4";
            this.pressAKeyLabel4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pressAKeyLabel4.Size = new System.Drawing.Size(78, 22);
            this.pressAKeyLabel4.TabIndex = 24;
            this.pressAKeyLabel4.Text = "press a key...";
            this.pressAKeyLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pressAKeyLabel3
            // 
            this.pressAKeyLabel3.AutoSize = true;
            this.pressAKeyLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressAKeyLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(140)))));
            this.pressAKeyLabel3.Location = new System.Drawing.Point(233, 81);
            this.pressAKeyLabel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pressAKeyLabel3.MinimumSize = new System.Drawing.Size(75, 0);
            this.pressAKeyLabel3.Name = "pressAKeyLabel3";
            this.pressAKeyLabel3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pressAKeyLabel3.Size = new System.Drawing.Size(78, 22);
            this.pressAKeyLabel3.TabIndex = 24;
            this.pressAKeyLabel3.Text = "press a key...";
            this.pressAKeyLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pressAKeyLabel2
            // 
            this.pressAKeyLabel2.AutoSize = true;
            this.pressAKeyLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressAKeyLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(140)))));
            this.pressAKeyLabel2.Location = new System.Drawing.Point(233, 50);
            this.pressAKeyLabel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pressAKeyLabel2.MinimumSize = new System.Drawing.Size(75, 0);
            this.pressAKeyLabel2.Name = "pressAKeyLabel2";
            this.pressAKeyLabel2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pressAKeyLabel2.Size = new System.Drawing.Size(78, 22);
            this.pressAKeyLabel2.TabIndex = 24;
            this.pressAKeyLabel2.Text = "press a key...";
            this.pressAKeyLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pressAKeyLabel1
            // 
            this.pressAKeyLabel1.AutoSize = true;
            this.pressAKeyLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressAKeyLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(140)))));
            this.pressAKeyLabel1.Location = new System.Drawing.Point(233, 20);
            this.pressAKeyLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pressAKeyLabel1.MinimumSize = new System.Drawing.Size(75, 0);
            this.pressAKeyLabel1.Name = "pressAKeyLabel1";
            this.pressAKeyLabel1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pressAKeyLabel1.Size = new System.Drawing.Size(78, 22);
            this.pressAKeyLabel1.TabIndex = 24;
            this.pressAKeyLabel1.Text = "press a key...";
            this.pressAKeyLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(134)))));
            this.label5.Location = new System.Drawing.Point(134, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label5.MinimumSize = new System.Drawing.Size(75, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Alt + Shift + ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(154)))), ((int)(((byte)(233)))));
            this.SpeedLabel.Location = new System.Drawing.Point(14, 20);
            this.SpeedLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpeedLabel.MinimumSize = new System.Drawing.Size(75, 0);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpeedLabel.Size = new System.Drawing.Size(110, 24);
            this.SpeedLabel.TabIndex = 24;
            this.SpeedLabel.Text = "Execute Profile 1";
            this.SpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HotkeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 217);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HotkeyForm";
            this.Text = "Rebind Hotkeys";
            this.Load += new System.EventHandler(this.HotkeyForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HotkeyForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyForm_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label pressAKeyLabel5;
        private System.Windows.Forms.Label pressAKeyLabel4;
        private System.Windows.Forms.Label pressAKeyLabel3;
        private System.Windows.Forms.Label pressAKeyLabel2;
        private System.Windows.Forms.Label pressAKeyLabel1;
    }
}