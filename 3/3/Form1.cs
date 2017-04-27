using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        Graphics g;
        Graphics gb;
        Mashinka car;
        Bitmap bmp;
        public int dx = 5;
        public int x = 0;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = pictureBox1.CreateGraphics();
            gb = Graphics.FromImage(bmp);
            timer1.Start();
        }
        public void draw()
        {
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            car = new Mashinka(x, 50);
            car.mdrow(g, new SolidBrush(Color.Red), new SolidBrush(Color.Black));
            x += dx;
            
        }
    }
}
