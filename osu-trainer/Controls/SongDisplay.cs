using FsBeatmapProcessor;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace osu_trainer.Controls
{
    public class SongDisplay : Control
    {
        private Font _difficultyFont;
        private Font _artistFont;
        private Font _titleFont;
        private Font _starsFont;

        public string Artist { get; set; }

        public string Title { get; set; }

        public string Difficulty { get; set; }

        public string ErrorMessage { get; set; }

        #region Star rating display
        private float _stars;
        private float _targetStars;
        public float Stars
        {
            get => _stars;
            set
            {
                _targetStars = value;
                _timer.Start();
                Invalidate(false);
            }
        }
        private GameMode gameMode = GameMode.osu;
        public GameMode GameMode
        {
            get => gameMode;
            set
            {
                updateIcon(gameMode = value, Enabled ? Colors.GetDifficultyColor(_stars) : Colors.Disabled);
                Invalidate(false);
            }
        }
        private Image _icon;
        private Image glow;

        private const float AnimationSpeed = .4f;
        private Timer _timer;

        private Color _lastColor = Color.Transparent;
        private GameMode _lastMode = GameMode.CatchtheBeat;
        #endregion

        private Image _cover;

        public SongDisplay()
        {
            updateFonts();
            DoubleBuffered = true;

            glow = Properties.Resources.glow;

            _timer = new Timer()
            {
                Interval = 33,
            };
            _timer.Elapsed += TimerOnElapsed;

            updateIcon(GameMode.osu, Enabled ? Colors.GetDifficultyColor(0) : Colors.Disabled);
        }

        public Image Cover
        {
            get => _cover;
            set
            {
                _cover = value;
                Invalidate(false);
            }
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            updateFonts();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (!string.IsNullOrWhiteSpace(ErrorMessage))
            {
                DrawErrorMessage(e.Graphics);
                return;
            }

            var height = Width / 4;

            // background
            if (Cover == null)
            {
                using (var brush = new SolidBrush(Colors.ReadOnlyBg))
                    e.Graphics.FillRectangle(brush, 0, 0, Width, height);
            }
            else
            {
                using (var background = prepareImage(Cover, Width, height))
                    e.Graphics.DrawImage(background, 0, 0, background.Width, background.Height);
            }
            // background dim
            using (var darkenBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0)))
                e.Graphics.FillRectangle(darkenBrush, 0, 0, Width, height);

            var bottom = height - 5;

            // map info
            var shadowColor = Color.FromArgb(128, 0, 0, 0);
            using (var shadowBrush = new SolidBrush(shadowColor))
            {
                // artist
                var artistHeight = (int)e.Graphics.MeasureString(Artist, _artistFont).Height;
                var artistY = bottom - artistHeight;
                e.Graphics.DrawString(Artist, _artistFont, shadowBrush, 5, artistY + 1);
                e.Graphics.DrawString(Artist, _artistFont, Brushes.White, 5, artistY);

                // title
                var titleFormat = new StringFormat()
                {
                    Trimming = StringTrimming.EllipsisCharacter
                };
                var titleHeight = e.Graphics.MeasureString(Title, _titleFont).Height;
                var titleY = artistY - titleHeight;
                var titleRectangle = new RectangleF(5, titleY, Width - 5, titleHeight);
                titleRectangle.Y++;
                e.Graphics.DrawString(Title, _titleFont, shadowBrush, titleRectangle, titleFormat);
                titleRectangle.Y--;
                e.Graphics.DrawString(Title, _titleFont, Brushes.White, titleRectangle, titleFormat);

                DrawDifficultyBadge(e.Graphics, shadowBrush);
                DrawStarRatingBadge(e.Graphics);
            }
        }

        private void DrawErrorMessage(Graphics graphics)
        {
            using (var textBrush = new SolidBrush(Colors.Salmon))
            {
                var rectangle = new RectangleF(0, 0, Width, Height);
                var format = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                graphics.DrawString(ErrorMessage, _titleFont, textBrush, rectangle, format);
            }
        }

        private void DrawDifficultyBadge(Graphics graphics, Brush shadowBrush)
        {
            if (string.IsNullOrWhiteSpace(Difficulty))
                return;

            var difficultySize = graphics.MeasureString(Difficulty, _difficultyFont);
            var difficultyWidth = difficultySize.Width + 30;
            var rectangle = new RectangleF(Width - 5 - difficultyWidth, 5, difficultyWidth, difficultySize.Height + 12);
            using (var path = JunUtils.RoundedRect(rectangle, 14))
            {
                graphics.FillPath(shadowBrush, path);
            }

            var difficultyFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            rectangle.Y += 3;
            graphics.DrawString(Difficulty, _difficultyFont, shadowBrush, rectangle, difficultyFormat);

            rectangle.Y -= 1;
            graphics.DrawString(Difficulty, _difficultyFont, Brushes.White, rectangle, difficultyFormat);
        }

        private Image prepareImage(Image image, int width, int height)
        {
            var bitmap = new Bitmap(width, height);

            using (var graphics = Graphics.FromImage(bitmap))
            {
                var scaleFactor = width / (float)image.Width;
                var newHeight = image.Height * scaleFactor;
                graphics.DrawImage(image, 0, (height / 2) - (newHeight / 2), width, newHeight);
            }

            return bitmap;
        }

        private void updateFonts()
        {
            _difficultyFont = new Font(Font.FontFamily, 12, FontStyle.Bold, GraphicsUnit.Pixel);
            _artistFont = new Font(Font.FontFamily, 14, FontStyle.Bold, GraphicsUnit.Pixel);
            _titleFont = new Font(Font.FontFamily, 20.8f, FontStyle.Bold, GraphicsUnit.Pixel);
            _starsFont = new Font(Font.FontFamily, 17f, FontStyle.Bold, GraphicsUnit.Pixel);
        }

        #region Star rating display
        private void DrawStarRatingBadge(Graphics graphics)
        {
            if (Stars <= 0)
                return;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            // shadow
            var shadowBrush = new SolidBrush(Color.FromArgb(240, 0, 0, 0));
            var shadowRectangle = new RectangleF(Width - 80, Height - 27, 77, 24);
            using (var path = JunUtils.RoundedRect(shadowRectangle, 11))
            {
                graphics.FillPath(shadowBrush, path);
            }

            // draw glow for hardest difficulties
            if (Stars >= 6.5)
            {
                graphics.DrawImage(glow, Width - 28, Height - 24);
            }

            var x = Width;

            if (_icon != null)
            {
                var size = 16;

                x -= size;
                graphics.DrawImage(_icon, x - 10, (Height - 6) - size, size, size);
                x -= 4;
            }

            var difficultyColor = Colors.GetDifficultyColor(Stars);
            if (Stars >= 6.5)
                difficultyColor = Color.White;

            using (var textBrush = new SolidBrush(Enabled ? difficultyColor : Colors.Disabled))
            {
                var text = $"{Stars:0.00}";
                var rectangle = new RectangleF(4, Height - 47, x - 14, Height/2 - 3);
                var format = new StringFormat
                {
                    LineAlignment = StringAlignment.Far,
                    Alignment = StringAlignment.Far,
                };

                graphics.DrawString(text, _starsFont, textBrush, rectangle, format);
            }
        }
        private void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            if (_stars == _targetStars)
                return;

            if (_targetStars > _stars)
                _stars += (_targetStars - _stars) * AnimationSpeed;
            else if (_targetStars < _stars)
                _stars -= (_stars - _targetStars) * AnimationSpeed;

            updateIcon(gameMode, Enabled ? Colors.GetDifficultyColor(_stars) : Colors.Disabled);

            Invalidate(false);
        }
        private void updateIcon(GameMode mode, Color color)
        {
            if (mode == _lastMode && color == _lastColor)
                return;

            if (_icon == null)
            {
                _icon = Icons.GenerateIcon(mode, color);
            }
            else
            {
                lock (_icon)
                {
                    _icon = Icons.GenerateIcon(mode, color);
                }
            }
            Invalidate(false);
        }
        #endregion
    }
}