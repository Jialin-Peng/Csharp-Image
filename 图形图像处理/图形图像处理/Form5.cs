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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush solidBrush = new SolidBrush(Color.Red);

            //定义填充范围 圆和正方形
            RectangleF yuan = new RectangleF(10, 10, 100, 100);
            RectangleF zhnegfangxing = new RectangleF(120, 10, 100, 100);

            //画出填充的圆和正方形
            g.FillEllipse(solidBrush, yuan);
            g.FillRectangle(solidBrush, zhnegfangxing);

            //画出填充的六边形
            Point p1 = new Point(230, 60);
            Point p2 = new Point(280, 10);
            Point p3 = new Point(330, 10);
            Point p4 = new Point(380, 60);
            Point p5 = new Point(330, 110);
            Point p6 = new Point(280,110);
            Point[] points1 = {p1, p2, p3, p4, p5,p6};
            
            //g.DrawPolygon(Pens.Red, points);
            g.FillPolygon(solidBrush, points1);

            //画出填充的圆角矩形
            Point[] points2 = new Point[6];
            for (int i = 0; i < points1.Length; i++) {
                int x= points1[i].X + 160;
                int y = points1[i].Y;
                Point point = new Point(x, y);
                points2[i] = point;
            }

            g.FillClosedCurve(solidBrush, points2);

            


        }
    }
}
