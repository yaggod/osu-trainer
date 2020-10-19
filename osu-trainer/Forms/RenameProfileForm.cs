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
    public partial class RenameProfileForm : Form
    {
        public string InputString;
        private int desiredStartLocationX;
        private int desiredStartLocationY;
        public RenameProfileForm(int x, int y)
        {
            this.desiredStartLocationX = x;
            this.desiredStartLocationY = y;
            InitializeComponent();
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            InputString = inputTextBox.Text;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RenameProfileForm_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(desiredStartLocationX, desiredStartLocationY);
        }

        private void RenameProfileForm_MouseLeave(object sender, EventArgs e)
        {
            var formBounds = new Rectangle(DesktopLocation.X, DesktopLocation.Y, Size.Width, Size.Height);
            if (!formBounds.Contains(Cursor.Position.X, Cursor.Position.Y))
                Close();
        }
    }
}
