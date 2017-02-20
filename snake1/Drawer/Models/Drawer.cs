using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Drawer.Modles
{
    [Serializable] // мод -) сериализируемый 
    class Drawer
    {
        public ConsoleColor color;
        public char sign;
        public List<Point> body = new List<Point>(); 

        public void Draw() // функция(метод) для рисования 
        {
            foreach (Point p in body)
            {
                if (p.x == Game.snake.body[0].x && p.y == Game.snake.body[0].y) Console.ForegroundColor = ConsoleColor.Red; // голова змейки красного цвета 
                else Console.ForegroundColor = color; // задаем цвет основного боди 
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
        
        public Drawer() // конструктор оставляем пустым (можно убрать)
        {

        }
        
        public void Save() // сохранение(сериализация) с помщью байнариформат
        {
            string filename = "";

            switch (sign)
            {
                case '#':
                    filename = "wall.dat";
                    break;
                case '*':
                    filename = "snake.dat";
                    break;
                case '$':
                    filename = "food.dat";
                    break;
            }

            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter wr = new BinaryFormatter();
            wr.Serialize(fs, this);

            fs.Close();
        }

        public void Resume() // продолжение (десериализация) игры
        {
            string fileName = "";

            switch (sign)
            {
                case '#':
                    fileName = "wall.dat";
                    break;
                case '$':
                    fileName = "food.dat";
                    break;
                case '*':
                    fileName = "snake.dat";
                    break;
            }

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryFormatter xs = new BinaryFormatter();
            
            switch (sign)
            {
                case '#':
                    Game.wall.body.Clear();
                    Game.wall = xs.Deserialize(fs) as Wall;
                    break;
                case '$':
                    Game.food.body.Clear();
                    Game.food = xs.Deserialize(fs) as Food;
                    break;
                case '*':
                    Game.snake.body.Clear();
                    Game.snake = xs.Deserialize(fs) as Snake;
                    break;
            }

            fs.Close();


        }



    }
}
