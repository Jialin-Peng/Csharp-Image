using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace 图形图像处理
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //SolidBrush solidBrush = new SolidBrush(Color.Red);

            Point point1 = new Point(10, 10);
            Point point2 = new Point(110, 110);

            Point point3 = new Point(120, 10);
            Point point4 = new Point(120, 110);

            Point point5 = new Point(380, 10);
            Point point6 = new Point(230, 110);

            Point point7 = new Point(600, 60);
            Point point8 = new Point(190, 60);


            LinearGradientBrush linearGradientBrush1 = new LinearGradientBrush(point1,point2,Color.White,Color.Red);
            LinearGradientBrush linearGradientBrush2= new LinearGradientBrush(point3, point4, Color.White, Color.Blue);
            LinearGradientBrush linearGradientBrush3 = new LinearGradientBrush(point5, point6, Color.White, Color.Red);
            LinearGradientBrush linearGradientBrush4 = new LinearGradientBrush(point7, point8, Color.White, Color.Blue);
            //定义填充范围 圆和正方形
            RectangleF yuan = new RectangleF(10, 10, 100, 100);
            RectangleF zhnegfangxing = new RectangleF(120, 10, 100, 100);
            
            //画出填充的圆和正方形
            g.FillEllipse(linearGradientBrush1, yuan);
            g.FillRectangle(linearGradientBrush2, zhnegfangxing);

            //画出填充的六边形
            Point p1 = new Point(230, 60);
            Point p2 = new Point(280, 10);
            Point p3 = new Point(330, 10);
            Point p4 = new Point(380, 60);
            Point p5 = new Point(330, 110);
            Point p6 = new Point(280, 110);
            Point[] points1 = { p1, p2, p3, p4, p5, p6 };

            //g.DrawPolygon(Pens.Red, points);
            g.FillPolygon(linearGradientBrush3, points1);

            //画出填充的圆角矩形
            Point[] points2 = new Point[6];
            for (int i = 0; i < points1.Length; i++)
            {
                int x = points1[i].X + 160;
                int y = points1[i].Y;
                Point point = new Point(x, y);
                points2[i] = point;
            }

            g.FillClosedCurve(linearGradientBrush4, points2);
        }
    }
}
