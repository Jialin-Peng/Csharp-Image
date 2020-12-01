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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("宋体", 22, FontStyle.Bold);
            
            //HatchBrush hatchBrush1 = new HatchBrush(HatchStyle.SolidDiamond, Color.Red);
            HatchBrush hatchBrush = new HatchBrush(HatchStyle.SolidDiamond,Color.Red,Color.Blue);
            Point point = new Point(300, 50);
            Point point1 = new Point(303, 53);
            Point point2 = new Point(300, 200);
          
            graphics.DrawString("阴影效果的文字", font, SystemBrushes.ControlDark, point1);
            graphics.DrawString("阴影效果的文字", font, Brushes.Red, point);
           // graphics.DrawString("彩色效果的文字", font, hatchBrush1, point2);
            graphics.DrawString("彩色效果的文字", font, hatchBrush, point2);

            Point point4 = new Point(20, 0);
            graphics.TranslateTransform(150, 140);
            Font font1 = new Font("宋体", 10, FontStyle.Bold);
            for (int i = 0; i < 80; i++)
            {
                graphics.RotateTransform(10);
                graphics.DrawString("旋转效果的文字", font1, hatchBrush, point4);
            }
            

        }
    }
}
