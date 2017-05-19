using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paintpro
{
    public partial class Form1 : Form
    {
        Graphics g;
        Graphics gb;
        Pen pen;
        SolidBrush brsh;
        bool mouseclicked = false;
        Point prev;
        Point cur;
        Bitmap bmp;
        enum Shape { PEN,LINE,ELL}
        Shape shape = new Shape();

        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Black);
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gb = Graphics.FromImage(bmp);
            shape = Shape.PEN;
            brsh = new SolidBrush(Color.White);
            g = pictureBox1.CreateGraphics();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prev = e.Location;
            mouseclicked = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (shape == Shape.LINE)
            {
                cur = e.Location;
                mouseclicked = false;
                gb.DrawLine(pen,prev, cur);
                pictureBox1.Image = bmp;
            }
            if (shape == Shape.PEN)
            {
                cur = e.Location;
                mouseclicked = false;
            }
            if (shape == Shape.ELL)
            {
                mouseclicked = false;
                gb.DrawEllipse(pen, prev.X, prev.Y, e.X - prev.X, e.Y - prev.Y);
                pictureBox1.Image = bmp;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (shape == Shape.LINE)
            {
                if (mouseclicked) {
                    Refresh();
                    g.DrawLine(pen, prev.X, prev.Y, e.X, e.Y);
                }
            }
            if (shape == Shape.PEN)
            {
                if (mouseclicked)
                {
                    g.DrawLine(pen, prev.X, prev.Y, e.X, e.Y);
                    prev = e.Location;
                }
            }
            if (shape == Shape.ELL)
            {
                if (mouseclicked)
                {
                    cur = e.Location;
                    if (cur.X > prev.X && cur.Y > prev.Y)
                    {
                        Refresh();
                        g.DrawEllipse(pen, prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y);
                    }
                    if (cur.X < prev.X && cur.Y < prev.Y)
                    {
                        Refresh();
                        g.DrawEllipse(pen, e.X, e.Y, prev.X - e.X, prev.Y - e.Y);

                    }
                    if (cur.X < prev.X && cur.Y > prev.Y)
                    {
                        Refresh();
                        g.DrawEllipse(pen, e.X, prev.Y, prev.X - e.X, e.Y - prev.Y);
                    }
                    if (cur.X > prev.X && cur.Y < prev.Y)
                    {
                        Refresh();
                        g.DrawEllipse(pen, prev.X, e.Y, e.X - prev.X, prev.Y - e.Y);
                    }
                }
            }

        }

        private void karandash_Click(object sender, EventArgs e)
        {
            shape = Shape.PEN;
        }

        private void line_Click(object sender, EventArgs e)
        {
            shape = Shape.LINE;
        }

        private void circle_Click(object sender, EventArgs e)
        {
            shape = Shape.ELL;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pen.Color = button2.BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pen.Color = button3.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pen.Color = button1.BackColor;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            gb.Clear(Color.White);
        }

        private void Allcolors_Click(object sender, EventArgs e)
        {
            DialogResult D = colorDialog1.ShowDialog();
            if (D == System.Windows.Forms.DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save("safe");
        }

        private void load_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("safe");
        }
    }
}
