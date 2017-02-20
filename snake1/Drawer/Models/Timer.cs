using Drawer.Modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Drawer.Models
{
    class PanelTimer
    {
        // public static Thread PanelTiming = new Thread(new ParameterizedThreadStart(Timing));
        public static Timer time = new Timer(new TimerCallback(seconding), st, 0, 1000);



        public static int seconds = 0;
        public static int minuts = 0;
        private static int st;

        public static void seconding(object st)
        {
            seconds++;
            if (seconds == 60)
            {
                minuts++;
                seconds = 0;
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("Time "+minuts + " : " + seconds);
        }

        /*private static void Timing(object obj)
        {
           while (Game.inGame) { 
            
            seconds++;

            if (seconds == 60)
            {
                minuts++;
                seconds = 0;
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(minuts + " : " + seconds);

                Thread.Sleep(500);
            }

            
        }*/
    }
}
