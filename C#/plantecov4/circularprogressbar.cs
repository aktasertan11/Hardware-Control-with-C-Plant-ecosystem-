using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
namespace plantecov4
{
    class circularprogressbar : UserControl
    {
        float val = 0, max = 100;
        public circularprogressbar()
        {
            DoubleBuffered = true;
        }
        public float Value { get { return val; } set { val = value; Invalidate(); } }
        public float Max { get { return val; } set { max = value; Invalidate(); } }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.DeepSkyBlue, 30) { StartCap = LineCap.Round, EndCap = LineCap.Round };

            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.FillPie(new SolidBrush(Color.White), new Rectangle(40, 40, Width - 75, Height - 75), 0, 360);
            g.DrawArc(pen, new Rectangle(40, 40, Width - 75, Height - 75), -20, (val / 100) * 360);

            StringFormat sf = new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center };
            g.DrawString(val + "%", Font, new SolidBrush(Color.DeepSkyBlue), ClientRectangle, sf);
            base.OnPaint(e);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // circularprogressbar
            // 
            this.Name = "circularprogressbar";
            this.Size = new System.Drawing.Size(747, 521);
            this.Load += new System.EventHandler(this.circularprogressbar_Load);
            this.ResumeLayout(false);

        }

        private void circularprogressbar_Load(object sender, EventArgs e)
        {

        }

        protected override void OnResize(EventArgs e)
        {
            Height = Width;
            base.OnResize(e);
        }
    }
}
