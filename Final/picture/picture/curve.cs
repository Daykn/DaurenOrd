using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace picture
{
    class curve
    {
        public int x, y;
        static Point[] k = new Point[2];
        
        public curve(int x, int y)
        {
            this.x = x;
            this.y = y;
            k[0].X = x;
            k[0].Y = y;
            k[1].X = 20;
            k[1].Y = 20;
        }
        public void Draw(Graphics g,SolidBrush b)
        {
            g.FillEllipse(b,k[0].X,k[0].Y,k[1].X, k[1].Y);
        }
    }
}
