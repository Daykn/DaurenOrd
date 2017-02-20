using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawer.Modles
{
    class Panel 
    {
        
        public static void UpnDownDraw()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan; // верхний и нижний границы 
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("_______________________________________________________________________________");
            Console.SetCursorPosition(0, 28);
            Console.WriteLine("_______________________________________________________________________________");
        }

        public static void PanelStaticDraw() // информация о игре
        {
            Console.Clear();
            UpnDownDraw();
            Console.SetCursorPosition(0, 0); // аддишн информэйшн
            Console.Write("SNAKE 1.0 by KNG") ;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("        ENJOY:)");

            

            Console.SetCursorPosition(48, 0); // информация про сохрание - продолжение 
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("F1 - save");
            Console.SetCursorPosition(48, 1);
            Console.Write("F2 - resume");

           

            // рисуем всё заново

            Game.wall.Draw();

       }
        

        public static void PanelDinamicDraw(int score, int level)
        {
            Console.SetCursorPosition(20, 2); // основная информация
            Console.ForegroundColor = ConsoleColor.Gray;
         //   Console.WriteLine("LEVEL : " + " " + "   SCORE : " + " ");
          //  Console.SetCursorPosition(20, 2);
            Console.WriteLine("LEVEL :" + level + "   SCORE :"+ score);
        } 

        public static void Time()
        {
            
        }
    }
}
