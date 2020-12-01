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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            HatchBrush hatchBrush1 = new HatchBrush(HatchStyle.Percent50, Color.Red);
            g.FillEllipse(hatchBrush1, 10, 10, 300, 300);

            HatchBrush hatchBrush2 = new HatchBrush(HatchStyle.Cross, Color.Red);
            g.FillRectangle(hatchBrush2, 330, 10, 300, 300);
        }
    }
}
