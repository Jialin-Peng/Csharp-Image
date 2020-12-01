using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图形图像处理
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //画非闭合曲线
            Point pf1 = new Point(panel1.Width / 8, panel1.Height / 3 / 2);
            Point pf2 = new Point(panel1.Width / 4, panel1.Height / 3 -panel1.Height/12); 
            Point pf3 = new Point(panel1.Width / 3, panel1.Height / 12);
            Point pf4 = new Point(panel1.Width / 2, panel1.Height / 3 /2);
            Point pf5 = new Point(panel1.Width / 3*2, panel1.Height / 3 -panel1.Width/10);
            Point pf6 = new Point(panel1.Width-panel1.Width/8, panel1.Height / 3 / 2);
            Point[] pfs = { pf1,pf2,pf3,pf4,pf5,pf6 };
            g.DrawCurve(Pens.Red, pfs,0.8f);

            //画封闭曲线
            Point pfb1 = new Point(panel1.Width / 8, panel1.Height/3+panel1.Height / 3 / 2);
            Point pfb2 = new Point(panel1.Width / 4, panel1.Height / 3 + panel1.Height / 12);
            Point pfb3 = new Point(panel1.Width / 3, panel1.Height / 3*2-panel1.Height/12);
            Point pfb4 = new Point(panel1.Width / 2, panel1.Height / 3 + panel1.Height / 3 / 2);
            Point pfb5 = new Point(panel1.Width / 3 * 2, panel1.Height / 3 * 2 - panel1.Height / 12);
            Point pfb6 = new Point(panel1.Width - panel1.Width / 8, panel1.Height / 3 +panel1.Height/8);
            Point[] pfbs = { pfb1, pfb2, pfb3, pfb4, pfb5, pfb6 };
            g.DrawClosedCurve(Pens.Red, pfbs);

            //画布赛尔曲线
            Point pb1 = new Point(panel1.Width / 8, (panel1.Height / 3)*2+ (panel1.Height / 3) / 2);
            Point pb2 = new Point(panel1.Width / 4, (panel1.Height/3)*2);
            Point pb3 = new Point(panel1.Width / 3, panel1.Height);
            Point pb4 = new Point(panel1.Width / 2, (panel1.Height / 3) * 2 + (panel1.Height / 3) / 2);
            Point pb5 = new Point(panel1.Width / 3*2, panel1.Height-panel1.Height/5);
            Point pb6 = new Point(panel1.Width / 3 * 2+ panel1.Width/8, panel1.Height);
            Point pb7 = new Point(panel1.Width - panel1.Width/8, (panel1.Height / 3) * 2 + (panel1.Height / 3) / 2);
            g.DrawBezier(Pens.Red, pb1, pb2, pb3, pb4);
            g.DrawBezier(Pens.Red, pb4, pb5, pb6, pb7);
        }
    }
}
