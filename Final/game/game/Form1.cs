using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        public Bitmap bmp;
        public Graphics g;
        public Pen pen;
        public SolidBrush brsh;
        public int a = 10, b = 10, a1 = 5, b1 = 5;
        public int c = 40, d = 14, c1 = 7, d1 = 9;
        public char n;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                n = 'u';
            if (e.KeyCode == Keys.Down)
                n = 'd';
            if (e.KeyCode == Keys.Right)
                n = 'r';
            if (e.KeyCode == Keys.Left)
                n = 'l';
        }

        public int x=100, y=100;

        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Black);
            brsh = new SolidBrush(Color.Blue);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);

            g.FillEllipse(brsh,a, b, 28, 28);
            a += a1;
            b += b1;
            if (a + 28 >pictureBox1.Width)
                a1 *= -1;
            if (b + 28 > pictureBox1.Height)
                b1 *= -1;
            if (a < 0)
                a1 *= -1;
            if (b < 0)
                b1 *= -1;
            if (a < x & b < y & a + 28 > x & b + 28 > y)
            {
                timer1.Stop();
                g.DrawString("Game  Over", Font, new SolidBrush(Color.Black), 100, 200);
            }
            if(a<x+50 & b<y+50 & a+28>x+50 & b+28>y+50)
            {
                timer1.Stop();
                g.DrawString("Game  Over", Font, new SolidBrush(Color.Black), 100, 200);
            }
            g.FillEllipse(brsh, c, d, 28, 28);
            c += c1;
            d += d1;
            if (c + 28 > pictureBox1.Width)
                c1 *= -1;
            if (d + 28 > pictureBox1.Height)
                d1 *= -1;
            if (c < 0)
                c1 *= -1;
            if (d < 0)
                d1 *= -1;

            ship sh = new ship(x, y);
            sh.Sdraw(g, new SolidBrush(Color.Red));
            if (n == 'u')
                y -= 7;
            if (n == 'd')
                y += 7;
            if (n == 'r')
                x += 7;
            if (n == 'l')
                x -= 7;
            if (x + 50 > pictureBox1.Width)
                x = pictureBox1.Width-50;
            if (x < 0)
                x = 0;
            if (y + 50 > pictureBox1.Height)
                y = pictureBox1.Height - 50;
            if (y < 0)
                y = 0;


            pictureBox1.Image = bmp;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
