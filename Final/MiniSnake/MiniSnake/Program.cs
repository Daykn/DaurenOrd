using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniSnake
{
    class Program
    {
        public static Snake snake;
        static Thread Game = new Thread(new ThreadStart(Go));
        public static bool InGame = true;

        static void Main(string[] args)
        {
            Console.Clear();

            snake = new Snake();
            Game.Start();
            while (InGame)
            {
                snake.Draw();

                switch (snake.direction)
                {
                    case 'd':
                        snake.move(0, 1);
                        break;
                    case 'u':
                        snake.move(0, -1);
                        break;
                    case 'r':
                        snake.move(1, 0);
                        break;
                    case 'l':
                        snake.move(-1, 0);
                        break;
                       

                }
                Thread.Sleep(300);
            }

        }

        private static void Go()
        {
            while (InGame)
            {
                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.DownArrow:
                        snake.direction = 'd';
                        break;
                    case ConsoleKey.UpArrow:
                        snake.direction = 'u';
                        break;
                    case ConsoleKey.RightArrow:
                        snake.direction = 'r';
                        break;
                    case ConsoleKey.LeftArrow:
                        snake.direction = 'l';
                        break;
                }
                Thread.Sleep(20);
            }
        }
    }
}
