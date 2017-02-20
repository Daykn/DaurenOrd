using Drawer.Modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawer.Models
{
    class MovingByDirection
    {        
       //string direction
        public static void SnakeToRight()
        {
            Game.snake.Move(1, 0);  
        }
        public static void SnakeToLeft()
        {
            Game.snake.Move(-1, 0);
        }
        public static void SnakeToUp()
        {
            Game.snake.Move(0, -1);
        }
        public static void SnakeToDown()
        {
            Game.snake.Move(0, 1);
        }
    }
}
