using Drawer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawer.Modles
{
    class EndGame
    {
        public static void lastKey()
        {
            ConsoleKeyInfo lastKey = Console.ReadKey();

            switch (lastKey.Key) // выбор между выходом и новой игрой 
            {
                case ConsoleKey.Escape:
                    Game.inGame = false;
                    Console.Clear();
                    break;
                case ConsoleKey.Y:
                    Console.Clear();
                    Program.Main();
                    break;
                case ConsoleKey.F2:
                    Console.Clear();
                    SaveResume.Resume();
                    break;
                default:
                    break;
            }
        } // ласт баттн
        public static void endGame() // конец игры
        {
            Game.inGame = false;
            PanelTimer.time.Dispose();
            Console.Clear();
            Console.SetCursorPosition(25, 10);
            Console.WriteLine("GAME OVER");
        }
    }
}
//ass