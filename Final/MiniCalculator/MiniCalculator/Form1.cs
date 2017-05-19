using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCalculator
{
    public partial class Form1 : Form
    {
        public double a,b;
        public bool plus = false;
        public bool minus =false;
        public bool mult = false;
        public bool div = false;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void todef()
        {
            plus = false;
            minus = false;
            mult = false;
            div = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void buttonPLUS_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                todef();
                plus = true;
                a = int.Parse(textBox1.Text);
                textBox1.Text = "";
            }
            else
                return;
        }

        private void buttonMINUS_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                todef();
                minus = true;
                a = int.Parse(textBox1.Text);
                textBox1.Text = "";
            }
            else
                return;
        }

        private void buttonMULT_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                todef();
                mult = true;
                a = int.Parse(textBox1.Text);
                textBox1.Text = "";
            }
            else
                return;
        }

        private void buttonDIV_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                todef();
                div = true;
                a = int.Parse(textBox1.Text);
                textBox1.Text = "";
            }
            else
                return;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            todef();
            textBox1.Text = "";
        }

        private void buttonEQUAL_Click(object sender, EventArgs e)
        {
            double res;
            b = int.Parse(textBox1.Text);
            if (plus)
            {
                res = a + b;
                textBox1.Text = res.ToString();
            }
            if (minus)
            {
                res = a - b;
                textBox1.Text = res.ToString();
            }
            if (mult)
            {
                res = a * b;
                textBox1.Text = res.ToString();
            }
            if (div)
            {
                res = a / b;
                textBox1.Text = res.ToString();
            }
        }
    }
}
