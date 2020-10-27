using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace osu_trainer.Controls
{
    public class OsuCheckBox : CheckBox
    {

        private bool textOnRight;
        [
        Category("Appearance"),
        Description("Sets the value when the nipple is slid all the way to the left"),
        DefaultValue(false)
        ]
        public bool TextOnRight
        {
            get => textOnRight;
            set
            {
                textOnRight = value;
                Invalidate();
            }
        }

        public Color DisabledColor { get; set; } = Colors.Disabled;

        private bool _hover;

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _hover = true;
            Invalidate(false);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _hover = false;
            Invalidate(false);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Parent.BackColor);

            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            var hoverPadding = 4f;
            var penWidth = 2;
            var indicatorWidth = 25;
            var indicatorRectangle = new RectangleF();
            if (textOnRight) // button on left
                indicatorRectangle.X = penWidth + (hoverPadding * 2);
            else // button on right
                indicatorRectangle.X = Width - indicatorWidth - penWidth - (hoverPadding * 2);
            indicatorRectangle.Y = penWidth + hoverPadding;
            indicatorRectangle.Width = indicatorWidth - penWidth;
            indicatorRectangle.Height = 13 - penWidth;

            // text begin
            var format = new StringFormat()
            {
                LineAlignment = StringAlignment.Center,
                Alignment = textOnRight ? StringAlignment.Far : StringAlignment.Near
            };
            var textOffsetY = Font.GetHeight() / 10;
            var textRectangle = new RectangleF();
            if (textOnRight) // text on right
                textRectangle.X = indicatorRectangle.Right;
            else // text on left
                textRectangle.X = 0;
            textRectangle.Y = textOffsetY;
            textRectangle.Width = textOnRight ? Width - indicatorRectangle.Width - 2 : indicatorRectangle.Right - 2;
            textRectangle.Height = Height + textOffsetY;
            e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), textRectangle, format);
            // text end

            var checkedBorderColor   = !Enabled ? DisabledColor : _hover ? Color.FromArgb(255, 221, 238)     : Color.FromArgb(255, 102, 170);
            var checkedFillColor     = !Enabled ? DisabledColor : _hover ? Color.FromArgb(255, 221, 238)     : Color.FromArgb(255, 102, 170);
            var uncheckedBorderColor = !Enabled ? DisabledColor : _hover ? Color.FromArgb(255, 221, 238)     : Color.FromArgb(255, 102, 170);
            var uncheckedFillColor   = !Enabled ? DisabledColor : _hover ? Color.FromArgb(172, 192, 22, 123) : Color.FromArgb(0, 0, 0, 0);

            using (var path = JunUtils.RoundedRect(indicatorRectangle, 5))
            {
                var fillRectangle = new Rectangle(Width - indicatorWidth, 0, indicatorWidth, 15);

                // inner fill
                using (var innerBrush = new SolidBrush(Checked ? checkedFillColor : uncheckedFillColor))
                {
                    e.Graphics.FillPath(innerBrush, path);
                }

                // outer border
                using (var pen = new Pen(Checked ? checkedBorderColor : uncheckedBorderColor, penWidth))
                {
                    e.Graphics.DrawPath(pen, path);
                }

            }
        }
    }
}