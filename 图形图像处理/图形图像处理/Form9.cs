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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Paint(object sender, PaintEventArgs e)
        {
            //1
            Graphics g = e.Graphics;
            Rectangle rectangle = new Rectangle(20, 20, 240, 240);
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(rectangle);
            g.FillEllipse(Brushes.White,rectangle);

            PathGradientBrush pathGradientBrush = new PathGradientBrush(graphicsPath);
            pathGradientBrush.CenterColor = Color.White;
            pathGradientBrush.SurroundColors = new Color[]
            {
                Color.Red
            };
            g.FillPath(pathGradientBrush, graphicsPath);
            
            graphicsPath.Dispose();
            pathGradientBrush.Dispose();


            //2

            Rectangle rectangle1 = new Rectangle(300, 20, 240,240);
            GraphicsPath graphicsPath1 = new GraphicsPath();
            graphicsPath1.AddEllipse(rectangle1);

            PathGradientBrush pathGradientBrush1 = new PathGradientBrush(graphicsPath1);
            //pathGradientBrush1.CenterColor = Color.White;
            float x=pathGradientBrush1.CenterPoint.X;
            float y = pathGradientBrush1.CenterPoint.Y;
            pathGradientBrush1.SurroundColors = new Color[]
            {
              // Color.Red,
                Color.Green,
               
                //Color.Gray,Color.Azure

            };
            
            g.FillPath(pathGradientBrush1, graphicsPath1);

            graphicsPath1.Dispose();
            pathGradientBrush1.Dispose();


            Rectangle rectangle2 = new Rectangle(Convert.ToInt32(x) - 80-8, Convert.ToInt32(y)-80, 160, 160);
            g.FillEllipse(Brushes.White, rectangle2);



            Rectangle rectangle3 = new Rectangle(Convert.ToInt32(x)-40-8, Convert.ToInt32(y)-40, 80, 80);
            GraphicsPath graphicsPath3 = new GraphicsPath();
            graphicsPath3.AddEllipse(rectangle3);

            PathGradientBrush pathGradientBrush3 = new PathGradientBrush(graphicsPath3);
           
            
            pathGradientBrush3.SurroundColors = new Color[]
            {
               Color.Red,
                //Color.Green,
               
                //Color.Gray,Color.Azure

            };

            g.FillPath(pathGradientBrush3, graphicsPath3);

            graphicsPath3.Dispose();
            pathGradientBrush3.Dispose();
        }
    }
}
