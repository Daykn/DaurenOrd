using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace _3
{
    class Mashinka
    {
        public int x, y;

        public Mashinka(int x,int y)
        {
            this.x = x;
            this.y = y;
            
        }
        public void mdrow(Graphics g, Brush b,Brush c)
        {
            g.FillRectangle(b, x + 50, y, 50, 100);
            g.FillRectangle(b, x, y + 50, 100, 50);
            g.FillEllipse(c, x + 35, y + 80, 30, 30);
            g.FillEllipse(c, x + 70, y + 80, 30, 30);
        }
    }
    
}
