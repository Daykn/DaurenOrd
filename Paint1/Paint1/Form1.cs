using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint1
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        bool Mouseclicked = false;
        Point prev;
        Point cur;
        Bitmap bmp;
        Graphics gb;
        enum Shape {LINE, PEN}
        Shape shape = new Shape();
        public Form1()
        {
            InitializeComponent();
            Draw();
            pen = new Pen(Color.Black);
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            shape= Shape.LINE;
            gb = Graphics.FromImage(bmp);
        }

        private void Draw() {
            g = pictureBox1.CreateGraphics();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(pen,prev.X,prev.Y,cur.X,cur.Y);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
            prev = e.Location;
            Mouseclicked = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (shape == Shape.LINE)
            {
                cur = e.Location;
                Mouseclicked = false;
                gb.DrawLine(pen, prev, cur);
                pictureBox1.Image = bmp;
            }
            if(shape==Shape.PEN)
            {
                cur = e.Location;
                Mouseclicked = false;
                
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (shape == Shape.LINE) {
                if (Mouseclicked)
                {
                    cur.X = e.X;
                    cur.Y = e.Y;
                    Refresh();
                }
            }
            if (shape == Shape.PEN)
            {
                if (Mouseclicked)
                {
                    g.DrawLine(pen, prev.X, prev.Y, e.X, e.Y);
                    prev = e.Location;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            pen = new Pen(Color.Red);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Green);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Blue);
        }

        private void Karandash_Click(object sender, EventArgs e)
        {
            shape = Shape.PEN;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            shape = Shape.LINE;

        }
    }
}
