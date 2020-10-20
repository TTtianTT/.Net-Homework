using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaylayTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(Convert.ToInt32(n_txtBox.Text), 200, 310, Convert.ToDouble(leng_txtBox.Text), -Math.PI / 2);
        }

        private Graphics graphics;
        //double th2 = 20 * Math.PI / 180;
        //double per1 = 0.6;
        //double per2 = 0.7;

        void drawCayleyTree(int n, double x0,double y0,double leng,double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            double d_1 = Convert.ToDouble(th1_txtBox.Text);
            double d_2 = Convert.ToDouble(th2_txtBox.Text);
            double d_3 = Convert.ToDouble(per1_txtBox.Text);
            double d_4 = Convert.ToDouble(per2_txtBox.Text);
            double th1 = Math.PI / 180 * d_1;
            double th2 = Math.PI / 180 * d_2;
            double per1 = d_3;
            double per2 = d_4;

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0,double y0,double x1,double y1)
        {
            switch(comboBox1.Text)
            {
                case "Blue":
                    graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "Red":
                    graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "Pink":
                    graphics.DrawLine(Pens.Pink, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "Purple":
                    graphics.DrawLine(Pens.Purple, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "Green":
                    graphics.DrawLine(Pens.Green, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                default:
                    break;
            }
            //graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void per1_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
