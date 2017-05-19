using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace picture
{
    class Rect
    {
        public int x, y;
        public static Point[] p = new Point[2];

        public Rect(int x,int y)
        {
            this.x = x;
            this.y = y;
            p[0].X = x;
            p[0].Y = y;
            p[1].X = 40;
            p[1].Y = 40;
        }
        public void RDraw(Graphics gr,SolidBrush s)
        {
            gr.FillRectangle(s, p[0].X, p[0].Y, p[1].X, p[1].Y);
        }
    }
}
