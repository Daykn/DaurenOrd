using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSnake
{
    class Snake
    {
        public char sign;
        public ConsoleColor color;
        public List<Point> body;
        public char direction;

        public Snake()
        {
            sign = '0';
            color = ConsoleColor.Red;
            body = new List<Point>();
            body.Add(new Point(20, 20));
            direction = 'd';   
        }
        public void move(int dx,int dy)
        {
            for(int i = body.Count()-1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            int curx = body[0].x + dx;
            int cury = body[0].y + dy;

            if (curx > 40)
                body[0].x = 0;
            if (curx < 0)
                body[0].x = 40;
            if (cury > 40)
                body[0].y = 0;
            if (cury < 0)
                body[0].y = 40;

            for(int i = 1; i < body.Count; i++)
            {
                if(body[0].x==body[i].x & body[0].y == body[i].y)
                {
                    Console.Clear();
                    Console.SetCursorPosition(15, 15);
                    Console.WriteLine("GameOver");
                    Console.ReadKey();
                    break;
                }
            }
        }
        public void Draw()
        {
            for(int i = 0; i < body.Count; i++)
            {
                if (i == 0)
                    Console.ForegroundColor = color;
                else
                    Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(body[i].x, body[i].y);
                Console.Write(sign);
            }
        }
        
    }
}
