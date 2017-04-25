using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace гонки
{
    class Mashinka
    {
        public int x;
        public int y;
        public Point[] ma=new Point[16];

        public Mashinka(int x,int y)//Graphics g , Brush br
        {
            this.x = x;
            this.y = y;
            ma[0].X = x;
            ma[0].Y = y;

            ma[1].X = x;
            ma[1].Y = y+20;

            ma[2].X = x+20;
            ma[2].Y = y+20;

            ma[3].X = x+20;
            ma[3].Y = y+40;

            ma[4].X = x;
            ma[4].Y = y+40;

            ma[5].X = x;
            ma[5].Y = y+60;

            ma[6].X = x+20;
            ma[6].Y = y+60;

            ma[7].X = x+20;
            ma[7].Y = y+80;

            ma[8].X = x-40;
            ma[8].Y = y+80;

            ma[9].X = x-40;
            ma[9].Y = y+60;

            ma[10].X = x-20;
            ma[10].Y = y+60;

            ma[11].X = x-20;
            ma[11].Y = y+40;

            ma[12].X = x-40;
            ma[12].Y = y+40;

            ma[13].X = x-40;
            ma[13].Y = y+20;

            ma[14].X = x-20;
            ma[14].Y = y+20;

            ma[15].X = x-20;
            ma[15].Y = y;

        }
        public void MDraw(Graphics g,Brush b)
        {
            g.FillPolygon(b, ma);
        }
    }
}
