using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prikol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int n;
        public int m;
        public Point p;
        private void button2_MouseHover(object sender, EventArgs e)
        {
            Random rand = new Random();
            n = rand.Next(1,245);
            Random rand1 = new Random();
            m = rand1.Next(1, 241);
            p.X = n;
            p.Y = m;
            button2.Location=p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Мы и не сомневались)";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            n = rand.Next(1, 245);
            Random rand1 = new Random();
            m = rand1.Next(1, 241);
            p.X = n;
            p.Y = m;
            button2.Location = p;

        }
    }
}
