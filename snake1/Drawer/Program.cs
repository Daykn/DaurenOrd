using Drawer.Models;
using Drawer.Modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Drawer
{
    class Program
    {
        public static Thread Progress = new Thread(new ParameterizedThreadStart(MainGame));
        public static Thread Direction = new Thread(new ParameterizedThreadStart(Itstime));

        public static void Main()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(60, 35); // консоль позишн
            Levels.LoadLevel(Game.level); // загружаем карту (уровень)
           // Levels.LoadLevel(3);
            Game.inGame = true; // положение игры активное
            Panel.PanelStaticDraw();
            Game.InitRandom(); // задаем змейке и еде начальные рандомные координаты 

            // PanelTimer.PanelTiming.Start();
            PanelTimer.time.Change(0, 1000);

            Progress.Start();
            if (Game.inGame == false) Progress.Abort();

        }

        private static void MainGame(object obj)
        {
            Direction.Start();
            
            Console.ReadKey();
            while (Game.inGame)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();

                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Game.snake.body.Count != 1 && Game.direction == "down") ;
                        else Game.direction = "up";
                        break;
                    case ConsoleKey.DownArrow:
                        if (Game.snake.body.Count > 1 && Game.direction == "up") ;
                        else Game.direction = "down";
                        break;
                    case ConsoleKey.LeftArrow:
                        if (Game.snake.body.Count > 1 && Game.direction == "right") ;
                        else Game.direction = "left";
                        break;
                    case ConsoleKey.RightArrow:
                        if (Game.snake.body.Count > 1 && Game.direction == "left") ;
                        else Game.direction = "right";
                        break;
                    case ConsoleKey.Escape:
                        Game.inGame = false;
                        EndGame.lastKey();
                        break;
                    case ConsoleKey.F1:
                        SaveResume.Save();
                        break;
                    case ConsoleKey.F2:
                        Console.Clear();
                        Panel.PanelStaticDraw();
                        SaveResume.Resume();
                        break;
                    default:
                        break;
                }
            }
        }

        private static void Itstime(object obj) // основы движения змейки
         {
            while (Game.inGame)
            {
                switch (Game.direction)
                {
                    case "right":
                            MovingByDirection.SnakeToRight();
                        break;
                    case "left":
                        MovingByDirection.SnakeToLeft();
                        break;
                    case "up":
                        MovingByDirection.SnakeToUp();
                        break;
                    case "down":
                        MovingByDirection.SnakeToDown();
                        break;
                }


                Game.DrawingSnake();
                Thread.Sleep(100);
                
            }
        }

        




    }
}
 