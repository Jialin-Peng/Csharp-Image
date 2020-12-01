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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
     

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Refresh();//刷新画板
            int num = int.Parse(textBox1.Text);
            
            int size = 200;
            int R = size / 2;
            Graphics g = this.panel1.CreateGraphics();

            g.TranslateTransform(panel1.Width/2,panel1.Height/2);
            double fAngel = Math.PI * 2 / num;
            double fStartAngel = Math.PI / 2f + fAngel / 2f;
            PointF ptfStart = new PointF(R * (float)Math.Cos(fStartAngel), -R * (float)Math.Sin(fStartAngel));
            for (int i = 0; i < num; i++)
            {
                fStartAngel += fAngel;
                PointF ptfEnd = new PointF(R * (float)Math.Cos(fStartAngel), -R * (float)Math.Sin(fStartAngel));
                g.DrawLine(Pens.Black, ptfStart, ptfEnd);
                ptfStart = ptfEnd;
            }
        }
    }
}
