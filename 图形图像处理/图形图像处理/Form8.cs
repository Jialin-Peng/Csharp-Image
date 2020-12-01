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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image image = Image.FromFile(@"D:\桌面\c#\图形图像处理\小姐姐.jpg");
            Rectangle rectangle = new Rectangle(0, 0, Form8.ActiveForm.Width-17, Form8.ActiveForm.Height-40);
            TextureBrush textureBrush = new TextureBrush(image,rectangle);
            g.FillEllipse(textureBrush, rectangle);
        }
    }
}
