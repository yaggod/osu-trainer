using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu_trainer.Forms
{
    public partial class HotkeyForm : Form
    {
        // TODO: move this to a separate class
        private static Dictionary<Keys, string> AcceptedKeysToString = new Dictionary<Keys, string>() {
            [Keys.A] = "A",
            [Keys.B] = "B",
            [Keys.C] = "C",
            [Keys.D] = "D",
            [Keys.E] = "E",
            [Keys.F] = "F",
            [Keys.G] = "G",
            [Keys.H] = "H",
            [Keys.I] = "I",
            [Keys.J] = "J",
            [Keys.K] = "K",
            [Keys.L] = "L",
            [Keys.M] = "M",
            [Keys.N] = "N",
            [Keys.O] = "O",
            [Keys.P] = "P",
            [Keys.Q] = "Q",
            [Keys.R] = "R",
            [Keys.S] = "S",
            [Keys.T] = "T",
            [Keys.U] = "U",
            [Keys.V] = "V",
            [Keys.W] = "W",
            [Keys.X] = "X",
            [Keys.Y] = "Y",
            [Keys.Z] = "Z",
            [Keys.D1] = "1",
            [Keys.D2] = "2",
            [Keys.D3] = "3",
            [Keys.D4] = "4",
            [Keys.D5] = "5",
            [Keys.D6] = "6",
            [Keys.D7] = "7",
            [Keys.D8] = "8",
            [Keys.D9] = "9",
            [Keys.D0] = "0",
            [Keys.OemMinus] = "-",
            [Keys.Oemplus] = "=",
            [Keys.OemOpenBrackets] = "[",
            [Keys.OemCloseBrackets] = "]",
            [Keys.OemPipe] = @"\",
            [Keys.OemSemicolon] = ";",
            [Keys.OemQuotes] = "'",
            [Keys.Oemtilde] = "`",
            [Keys.Oemcomma] = ",",
            [Keys.OemPeriod] = ".",
            [Keys.OemQuestion] = "/"
        };
        private int desiredStartLocationX;
        private int desiredStartLocationY;
        private bool WaitingForKeypress = false;
        private int WhichHotkey = 0; // 0: Generate Map, // 1-4: Execute Profile 1-4
        private List<Button> buttons;
        public List<Keys> Hotkeys;
        public HotkeyForm(int x, int y, List<Keys> hotkeys)
        {
            InitializeComponent();
            buttons = new List<Button>() { button5, button1, button2, button3, button4};

            desiredStartLocationX = x;
            desiredStartLocationY = y;

            if (hotkeys.Count != 5)
                throw new ArgumentException("bad hotkey list length");
            Hotkeys = hotkeys;

            UpdateButtonLabels();
            pressAKeyLabel1.Visible = false;
            pressAKeyLabel2.Visible = false;
            pressAKeyLabel3.Visible = false;
            pressAKeyLabel4.Visible = false;
            pressAKeyLabel5.Visible = false;
            Focus();
        }

        private void DisableAllButtons()
        {
            Console.WriteLine(button1.FlatAppearance.MouseDownBackColor);
            foreach (var button in buttons)
            {
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 44, 67);
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 44, 67);
                button.ForeColor = Color.DarkGray;
            }
        }
        private void EnableAllButtons()
        {
            foreach (var button in buttons)
            {
                button.FlatAppearance.MouseOverBackColor = Color.Empty;
                button.FlatAppearance.MouseDownBackColor = Color.Empty;
                button.ForeColor = Color.FromArgb(241, 250, 140);
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void closeButton_Click(object sender, EventArgs e) => Close();

        #region borderless window title bar
        private bool Drag;
        private int MouseX;
        private int MouseY;
        private void titlePanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            e.Graphics.DrawString(Text, new Font(Font, FontStyle.Regular), Brushes.White, 8, 8);
            ControlPaint.DrawBorder(e.Graphics, titlePanel.ClientRectangle,
                Color.Black, 1, ButtonBorderStyle.Solid, // left
                Color.Black, 1, ButtonBorderStyle.Solid, // top
                Color.Black, 1, ButtonBorderStyle.Solid, // right
                Color.FromArgb(43, 32, 56), 1, ButtonBorderStyle.Solid); // bottom
        }

        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }

        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }
        private void titlePanel_MouseUp(object sender, MouseEventArgs e) => Drag = false;
        #endregion

        private void HotkeyForm_Paint(object sender, PaintEventArgs e)
        {
            var borderRect = new Rectangle(ClientRectangle.X - 1, ClientRectangle.Y - 1, ClientRectangle.Width + 2, ClientRectangle.Height + 2);
            ControlPaint.DrawBorder(e.Graphics, borderRect, Color.Black, ButtonBorderStyle.Solid);
        }

        private void HotkeyForm_Load(object sender, EventArgs e)
        {
            DesktopLocation = new Point(desiredStartLocationX, desiredStartLocationY);
        }

        private void button1_Click(object sender, EventArgs e) => StartEditingHotkey(1);
        private void button2_Click(object sender, EventArgs e) => StartEditingHotkey(2);
        private void button3_Click(object sender, EventArgs e) => StartEditingHotkey(3);
        private void button4_Click(object sender, EventArgs e) => StartEditingHotkey(4);
        private void button5_Click(object sender, EventArgs e) => StartEditingHotkey(0);
        private void StartEditingHotkey(int whichHotkey)
        {
            if (WaitingForKeypress)
                return;
            WaitingForKeypress = true;
            WhichHotkey = whichHotkey;
            DisableAllButtons();
            buttons[WhichHotkey].ForeColor = Color.FromArgb(241, 250, 140);
            var labels = new List<Label>() { pressAKeyLabel5, pressAKeyLabel1, pressAKeyLabel2, pressAKeyLabel3, pressAKeyLabel4 };
            labels[whichHotkey].Visible = true;
        }
        private void StopEditingHotkey()
        {
            WaitingForKeypress = false;
            EnableAllButtons();
            pressAKeyLabel1.Visible = false;
            pressAKeyLabel2.Visible = false;
            pressAKeyLabel3.Visible = false;
            pressAKeyLabel4.Visible = false;
            pressAKeyLabel5.Visible = false;
        }
        private void UpdateButtonLabels()
        {
            button5.Text = AcceptedKeysToString[Hotkeys[0]];
            button1.Text = AcceptedKeysToString[Hotkeys[1]];
            button2.Text = AcceptedKeysToString[Hotkeys[2]];
            button3.Text = AcceptedKeysToString[Hotkeys[3]];
            button4.Text = AcceptedKeysToString[Hotkeys[4]];
        }


        private void HotkeyForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (WaitingForKeypress)
                    StopEditingHotkey();
                else
                    Close();
                return;
            }

            if (WaitingForKeypress)
            {
                // check for profile hotkey conflict
                if (WhichHotkey >= 1 && WhichHotkey <= 4)
                {
                    for (int i = 1; i <= 4; i++)
                    {
                        if (WhichHotkey == i)
                            continue;
                        if (Hotkeys[i] == e.KeyCode)
                        {
                            foreach (var button in buttons)
                            {
                                if (button.ForeColor == Color.Red)
                                    button.ForeColor = Color.DarkGray;
                            }
                            buttons[i].ForeColor = Color.Red;
                            return;
                        }
                    }
                }
                if (AcceptedKeysToString.Keys.Contains(e.KeyCode))
                {
                    Hotkeys[WhichHotkey] = e.KeyCode;
                    UpdateButtonLabels();
                    StopEditingHotkey();
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle,
                Color.Black, 1, ButtonBorderStyle.Solid, // left
                Color.FromArgb(48, 44, 67), 1, ButtonBorderStyle.Solid, // top
                Color.Black, 1, ButtonBorderStyle.Solid, // right
                Color.Black, 1, ButtonBorderStyle.Solid); // bottom
        }
    }
}
