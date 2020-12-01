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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TranslateTransform(Form4.ActiveForm.Width / 3 * 2-80, Form4.ActiveForm.Height / 2-50);
            //显示坐标系
            g.DrawLine(Pens.Black,0, 0, -1000, 0);
            g.DrawLine(Pens.Black, 0, 0, 0, -1000);
            g.DrawLine(Pens.Black, 0, 0, 1000, 0);
            g.DrawLine(Pens.Black, 0, 0, 0, 1000);

            g.DrawEllipse(Pens.Red, -200, -50, 200, 100);//绘制椭圆
            g.DrawPie(Pens.Red, -50, -50, 100, 100, -40, 80);//绘制扇形
        }
    }
}
