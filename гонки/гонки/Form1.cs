using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace гонки
{
    public partial class Form1 : Form
    {
        public Graphics g;
        public Bitmap bmp;
        public Bitmap bmp2;
        public Brush br;
        Mashinka mash;
        public char u;//it is command char to rule my car
        public int x = 65;
        public int y = 170;
        public int x1=65;
        public int y1=0;
        public int x2=65;
        public int y2= -215;
        //here are locations
        public int n1 = 2;
        public int n2 = 2;
        //random nambers for appearence
        public int i = 0;
        // it is iterator one below
        public int y11 = 3;
        public int y21 = 3;
        public int up = 4;
        public int d = 4;
        public int r = 5;
        public int l = 5;
        //below are the speeds 
        public int z = 0;//tymer
        public string str;
        public int life=3;
         
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Begin:
        bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            br = new SolidBrush(Color.Yellow);

            g.FillRectangle(br, 10, 1, 10, 260);
            g.FillRectangle(br, 170, 1, 10, 260);

            
            mash = new Mashinka(x1, y1);
            mash.MDraw(g, new SolidBrush(Color.Red));

            y1 += y11;

            if (y1 > 370)
            {
                Random rand1 = new Random();
                n1 = rand1.Next(1, 5);

            if (n1 > 2)
                x1 = 65;
            else
                x1 = 140;

                y1 = -60;

            }
            //below mashinka 1 is locating

            mash = new Mashinka(x2, y2);
            mash.MDraw(g, new SolidBrush(Color.Red));
            y2 += y21;
            if (y2 > 370)
            {
                y2 = -60;
                Random rand = new Random();
                n2 = rand.Next(1, 5);

                if (n2 > 2)
                    x2 = 140;
                else
                    x2 = 65;

            }//below mashinka 2 is locating

            mash = new Mashinka(x, y);
                mash.MDraw(g, new SolidBrush(Color.Purple));
            
            if (u == 'u')
                y -= up;
            if (u == 'd')
                y += d;
            if (u == 'r')
                x += r;
            if (u == 'l')
                x -= l;
            if (u == 'a')
            {
                x += 0;
                y += 0;
            }
            //here I give commands where to turn
            if (x + 20 > 170)
                x -=1;
            if (x + 20 > 180)
                x = 160;
            if (x - 40 < 20)
                x += 1;
            if (x - 40 < 10)
                x = 50;
            if (y + 80 > 300)
                y = 220;
            if (y < 0)
                y = 0;
            //here I don't let my car out of picturebox
            if (x-40 < x1+20 && x+20 > x1+20 && y+5 < y1+80 && y+80 > y1+5 || x - 40 < x2 + 20 && x + 20 > x2 + 20 && y+5 < y2 + 80 && y + 80 > y2+5)
            {
                life--;
                if (life != 0)
                    x = 140;

                if (life == 0)
                {
                    timer1.Stop();
                    g.DrawString("GAME OVER",Font,new SolidBrush(Color.Yellow),70,140);
                    g.DrawString("Your Time is " + z, Font, new SolidBrush(Color.Yellow), 66, 160);
                }
            }
            //справа снизу
            if (x-40 < x1-40 && x+20 > x1-40 && y+5 < y1 + 80 && y + 80 > y1+5 || x - 40 < x2 - 40 && x + 20 > x2 - 40 && y+5 < y2 + 80 && y + 80 > y2+5)
            {
                life--;
                if (life != 0)
                {
                    x = 65;
                }

                    
                    //                    goto Begin;
                if (life == 0)
                {
                    timer1.Stop();
                    g.DrawString("GAME OVER", Font, new SolidBrush(Color.Yellow), 70, 140);
                    g.DrawString("Your Time is " + z, Font, new SolidBrush(Color.Yellow), 66, 160);
                }
            }
            //слева снизу

            i +=1;
            if(i%150==0)
            {
                y11 += 1;
                y21 += 1;
                up+=1;
                d +=1;
                r +=1;
                l += 1;
            }//below I increase a speed of everything
            if (i % 20 == 0)
                z++;
            
            g.DrawString("time: "+z,Font,br,200,49);
            g.DrawString("life Count = " + life, Font, br, 200, 60);

            pictureBox1.Image = bmp;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                u = 'u';
            if (e.KeyCode == Keys.Down)
                u = 'd';
            if (e.KeyCode == Keys.Right)
                u = 'r';
            if (e.KeyCode == Keys.Left)
                u = 'l';
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            u = 'a';
        }

        /* private void button1_Click(object sender, EventArgs e)
         {/*
             timer1.Stop();
             pictureBox1.Image = Properties.Resources.thumb_Modern_Car_Top_View_33_3_5597;
         }*/
    }
}
