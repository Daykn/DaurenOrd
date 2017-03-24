using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace clock
{
    class Program
    {
        public static  clocks clock = new clocks();
        public static List<Point> list;
        public static Thread time = new Thread(new ThreadStart(Go));
        static void Main(string[] args)
        {
            list = new List<Point>();
            list.Add(new Point(8, 0));
            list.Add(new Point(6, 1));
            list.Add(new Point(4, 2));
            list.Add(new Point(2, 3));
            list.Add(new Point(4, 4));
            list.Add(new Point(6, 5));
            list.Add(new Point(8, 6));
            list.Add(new Point(10, 5));
            list.Add(new Point(12, 4));
            list.Add(new Point(14, 3));
            list.Add(new Point(12, 2));
            list.Add(new Point(10, 1));

            time.Start();
            
            while (true)
            {
                
                foreach (Point p in list)
                {
                    clock.Draw();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(p.x, p.y);
                        Console.WriteLine('@');
                    Thread.Sleep(1000);
                    Console.Clear();
                }
             
            }
        }
        public static void Go() {
            Thread.Sleep(1000);
             
        }
    }
}
