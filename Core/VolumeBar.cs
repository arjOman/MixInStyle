using System.Drawing.Drawing2D;
using Timer = System.Windows.Forms.Timer;

namespace MixInStyle.Core
{
    public partial class VProgressBar : Control
    {

        public int Value { get; set; }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle = handleParam.ExStyle | 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        public VProgressBar()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            base.BackColor = Color.Gainsboro;
            Size = new Size(20, 150);
            Value = 80;
            Timer tmr = new Timer() { Interval = 10 };
            tmr.Tick += delegate { Invalidate(); };
            tmr.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                LinearGradientBrush brush = new LinearGradientBrush(e.ClipRectangle, Color.SpringGreen, Color.Red, -90f);
                Rectangle d = new Rectangle
                {
                    Size = new Size(Width, (int)(Value * Height / 100d))
                };
                d.Location = new Point(0, Height - d.Height);

                e.Graphics.FillRectangle(brush, d);
            }
            catch
            {

            }
        }
    }
}
