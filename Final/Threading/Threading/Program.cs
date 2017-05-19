using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        public static int d = 0;
        static void move()
        {
            while (true)
            {
                d += 1;
                Console.Clear();
                Console.SetCursorPosition(d, 6);
                Console.WriteLine("0000000>");
                if (d == 40)
                    d = 0;
                Thread.Sleep(60);
            }
        }
        static void Main(string[] args)
        {
            Thread thr = new Thread(move);
            thr.Start();
        }
    }
}
