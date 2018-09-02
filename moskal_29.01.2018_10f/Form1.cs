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

namespace moskal_29._01._2018_10f
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Black, 1);
            g.DrawLine(p, 0, this.Height / 2, this.Width, this.Height / 2);
            g.DrawLine(p, this.Width / 2, 0, this.Width / 2, this.Height);
            Pen p2 = new Pen(Color.DarkBlue, 1);
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            double x1, y1;
            double x0 = (a * Math.Cos(b * double.Parse(textBox3.Text) * double.Parse(textBox3.Text))) + this.Width / 2;
            double y0 = -1 * (a * Math.Sin(b * Math.Sqrt(double.Parse(textBox3.Text)))) + this.Height / 2;
            for(double t=double.Parse(textBox3.Text);t< double.Parse(textBox4.Text); t+=0.01)
            {
                x1 = (a*Math.Cos(b*t*t))+this.Width / 2;
                y1 = -1*(a*Math.Sin(b*Math.Sqrt(t)))+ this.Height/2;
                if (((x0 > -2000) && (x0 < 2000)) && ((y0 > -2000) && (y0 < 2000)) && ((x1 > -2000) && (x1 < 2000)) && ((y1 > -2000) && (y1 < 2000)))
                {
                    int X = Convert.ToInt32(x0);
                    int Y = Convert.ToInt32(y0);
                    int x = Convert.ToInt32(x1);
                    int y = Convert.ToInt32(y1);
                    g.DrawLine(p2, X, Y, x, y);
                }
                x0 = x1;
                y0 = y1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
