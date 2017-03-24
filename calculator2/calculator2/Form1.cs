using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2
{
    public partial class Form1 : Form
    {
        bool plus = false;
        bool minus = false;
        bool mult = false;
        bool div = false;
        bool isNegative = false;
        bool pow = false;
        double firstnum=0;
        double secondnum = 0;
        bool repeat = false;
        double n = 0;
        bool MS=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void toDefault()
        {
            plus = false;
            minus = false;
            mult = false;
            div = false;
            repeat = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += button0.Text;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            MS = false;
            textBox1.Text = "";
            firstnum = 0;
            toDefault();
            n = 0;
        }

        private void buttonPLUS_Click(object sender, EventArgs e)
        {
            toDefault();
            plus = true;
            repeat = false;
            firstnum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonMINUS_Click(object sender, EventArgs e)
        {
            toDefault();
            minus = true;
            repeat = false;
            firstnum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonDIVISION_Click(object sender, EventArgs e)
        {
            toDefault();
            div = true;
            repeat = false;
            firstnum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }
        
        private void buttonMULTYOLICATION_Click(object sender, EventArgs e)
        {
            toDefault();
            mult = true;
            repeat = false;
            firstnum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }
        
        private void buttonMS_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                MS = true;
                n = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(n);
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            n = 0;
            
        }

        private void buttonM_plus_Click(object sender, EventArgs e)
        {
            if (MS == true)
            {
                double s = double.Parse(textBox1.Text);
                n += s;
                textBox1.Text = "";
            }
        }

        private void buttonM_minus_Click(object sender, EventArgs e)

        {
            if (MS == true)
            {
                double s = double.Parse(textBox1.Text);
                n -= s;
                textBox1.Text = "";
            }
        }
        private void buttonSQRT_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                double d = Math.Sqrt(Convert.ToDouble(textBox1.Text));
                textBox1.Text = Convert.ToString(d);
            }
        }

        private void buttonStepen_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                pow = true;
                firstnum = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonEQUAL_Click(object sender, EventArgs e)
        {
            double pl = 0.0;
            if (repeat == false)
                secondnum = Convert.ToDouble(textBox1.Text);

            if (pow)
            {
                double z = Convert.ToDouble(textBox1.Text);
                pl = 1;
                for (int i = 1; i <= z; i++)
                {
                    pl *= firstnum;
                }
                textBox1.Text = Convert.ToString(pl);
            }

            if (plus)
            {
                pl = firstnum + secondnum;
                textBox1.Text = Convert.ToString(pl);
            }
            if (mult)
            {
                pl = firstnum * secondnum;
                textBox1.Text = Convert.ToString(pl);
            }
            if (div)
            {
                pl = firstnum / secondnum;
                textBox1.Text = Convert.ToString(pl);
            }
            if (minus)
            {
                pl = firstnum - secondnum;
                textBox1.Text = Convert.ToString(pl);
            }

            firstnum = pl;
            repeat = true;
        }
    }
}
