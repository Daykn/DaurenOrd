using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class ship
    {
        public int x, y;
        public Point[] po = new Point[2];

        public ship(int x,int y)
        {
            this.x = x;
            this.y = y;
            po[0].X = x;
            po[0].Y = y;
            po[1].X = 50;
            po[1].Y = 50;
        }
        public void Sdraw(Graphics gr,SolidBrush br)
        {
            gr.FillRectangle(br, po[0].X,po[0].Y, po[1].X,po[1].Y);
        }
    }
}
