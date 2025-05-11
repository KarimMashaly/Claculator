//using System;
//using System.Drawing;
//using System.Drawing.Drawing2D;
//using System.Windows.Forms;

//namespace Spotify_login_interface
//{
   

//    public class RoundedButton : Button
//    {
//        public int BorderRadius { get; set; } = 30;
//        public Color NormalBackColor { get; set; } = Color.LightGray;
//        public Color HoverBackColor { get; set; } = Color.LightGreen;

//        private bool isHovered = false;

//        public RoundedButton()
//        {
//            this.FlatStyle = FlatStyle.Flat;
//            this.FlatAppearance.BorderSize = 0;
//            this.BackColor = NormalBackColor;
//            this.ForeColor = Color.Black;
//            this.Resize += (s, e) => this.Invalidate();
//            this.MouseEnter += (s, e) => { isHovered = true; this.Invalidate(); };
//            this.MouseLeave += (s, e) => { isHovered = false; this.Invalidate(); };
//        }

//        protected override void OnPaint(PaintEventArgs e)
//        {
//            base.OnPaint(e);
//            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

//            //Rectangle rect = this.ClientRectangle;
//            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

//            using (GraphicsPath path = GetRoundedPath(rect, BorderRadius))
//            {
//                using (SolidBrush brush = new SolidBrush(isHovered ? HoverBackColor : NormalBackColor))
//                {
//                    e.Graphics.FillPath(brush, path);
//                }

//                int glowSize = 6;
//                Rectangle glowRect = new Rectangle(rect.X - glowSize, rect.Y - glowSize,
//                                                   rect.Width + glowSize * 2, rect.Height + glowSize * 2);

//                using (GraphicsPath glowPath = GetRoundedPath(glowRect, BorderRadius + glowSize))
//                using (Pen glowPen = new Pen(Color.FromArgb(100, Color.Orange), glowSize))
//                {
//                    glowPen.LineJoin = LineJoin.Round;
//                    e.Graphics.DrawPath(glowPen, glowPath);
//                }

//                this.Region = new Region(path);

//                TextRenderer.DrawText(e.Graphics, this.Text, this.Font, rect, this.ForeColor,
//                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
//            }
//        }

//        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
//        {
//            GraphicsPath path = new GraphicsPath();
//            float r = radius;
//            path.StartFigure();
//            path.AddArc(rect.Left, rect.Top, r, r, 180, 90);
//            path.AddArc(rect.Right - r, rect.Top, r, r, 270, 90);
//            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
//            path.AddArc(rect.Left, rect.Bottom - r, r, r, 90, 90);
//            path.CloseFigure();
//            return path;
//        }
//    }
//}
