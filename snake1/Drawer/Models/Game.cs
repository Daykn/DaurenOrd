using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawer.Modles
{
    class Game
    {
        // создаем стены, еду, змейку и переменные для уровней  //очки будем выводить как Snake.snake.body.Count;
        public static bool inGame; // состояние игры 
        public static Snake snake = new Snake();
        public static Food food = new Food();
        public static Wall wall = new Wall();
        public static int level = 1;
        public static string direction; // начальный путь змейки направлено на право;
        public static int tailsx;
        public static int tailsy;

        public static bool SnakeInWall(List<Point> wallbody, List<Point> snakebody, int x, int y)
        {
            for (int i = 0; i < wall.body.Count; i++)
            {
                if (snakebody[0].x == wallbody[i].x && snakebody[0].y == wallbody[i].y) return true;
            }
            return false;
        } // когда змейка не/появляется в стенке 

        public static bool FoodInWall(List<Point> wallbody, List<Point> foodbody, int x, int y)
        {
            for (int i = 0; i < wall.body.Count; i++)
            {
                if (foodbody[0].x == wallbody[i].x && foodbody[0].y == wallbody[i].y) return true;
            }
            return false;
        } // когда еда не/появляется в стенке

        public static void NewFood() // функция для нового положения еды если координаты совпали со змейкой 
        {
            food.body.Clear();
            food.body.Add(new Point { x = new Random().Next(0, 58), y = new Random().Next(4, 29) });
           
            while (FoodInWall(wall.body, food.body, food.body[0].x, food.body[0].y) == true) NewFood();

        }

        public static void NewSnake()
        {
            snake.body.Clear();
            snake.body.Add(new Point { x = new Random().Next(0, 58), y = new Random().Next(4, 29) });
            
        } //новые координаты змейки

        public static void InitRandom() // координаты змейки и еды
        {
            Console.Clear();
            Panel.UpnDownDraw();
            Panel.PanelStaticDraw();
            snake.body.Clear();
            food.body.Clear();
            

            snake.body.Add(new Point { x = new Random().Next(0, 58), y = new Random().Next(4, 29) });
            if (level != 4) food.body.Add(new Point { x = new Random().Next(0, 58), y = new Random().Next(4, 29) }); // END OF THE WHOLE GAME



            while ((snake.body[0].x == food.body[0].x && snake.body[0].y == food.body[0].y) || FoodInWall(wall.body, food.body, food.body[0].x, food.body[0].y) == true) // если координаты змейки и еды совпали 
            {
                NewFood();
            }

            food.Draw();

            while (SnakeInWall(wall.body, snake.body, snake.body[0].x, snake.body[0].y) == true) // если координаты змейки и стены совпали 
            {
                NewSnake();
            }
            snake.Draw();
        }

        
        public static void DrawingSnake()
        {
            Panel.PanelDinamicDraw(snake.body.Count - 1, level);
            snake.Draw();
            Snake.ClearSnakesTail(tailsx, tailsy);
            food.Draw();
        }

    }
  
}
