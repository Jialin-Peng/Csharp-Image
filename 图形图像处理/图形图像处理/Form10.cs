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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Bitmap bitmap = new Bitmap("D:\\桌面\\c#\\图形图像处理\\小姐姐1.jpg");
            int width = 280;//图片的原宽
            int height = 200;//图片的原高
            Rectangle rectangle = new Rectangle(20, 20, width , height);
            Rectangle rectangle1 = new Rectangle(40 + width, 20, width / 2, height / 2);
            Rectangle rectangle2 = new Rectangle(60 + width+width/2, 20, 200, 150);
            graphics.DrawImage(bitmap, rectangle);
            graphics.DrawImage(bitmap, rectangle1);
            graphics.DrawImage(bitmap, rectangle2);

            
        }
    }
}
