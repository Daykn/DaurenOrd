using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picture
{
    public partial class Form1 : Form
    {
        public Bitmap bmp;
        public Graphics g;
        public Form1()
        {
            InitializeComponent();
            Draw();
        }
        private void Draw()
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);

            g.FillRectangle(new SolidBrush(Color.Blue),0,0,400,400);

            curve e1 = new curve(100,100);
            e1.Draw(g, new SolidBrush(Color.Red));
            curve e2 = new curve(10, 100);
            e1.Draw(g, new SolidBrush(Color.Red));
            curve e3 = new curve(100, 10);
            e1.Draw(g, new SolidBrush(Color.Red));
            curve e4 = new curve(100, 200);
            e1.Draw(g, new SolidBrush(Color.Red));
            curve e5 = new curve(200, 100);
            e1.Draw(g, new SolidBrush(Color.Red));

            Rect r1 = new Rect(40, 40);
            r1.RDraw(g, new SolidBrush(Color.Green));

            pictureBox1.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
