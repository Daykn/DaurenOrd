using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock
{
    class clocks
    {
        public static List<Point> nums;
        public static ConsoleColor color;
        public clocks()
        {
            color = ConsoleColor.Green;
            nums = new List<Point>();
            StreamReader sr = new StreamReader(String.Format("a.txt"));
            string str = sr.ReadLine();
            int n = int.Parse(str);
            for (int i = 0; i < n; i++)
            {
                string str2 = sr.ReadLine();
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str2[j] == '*')
                    {
                        nums.Add(new Point(j, i));
                    }
                }
            }
            sr.Close();
        }
        public void Draw() {
            Console.ForegroundColor = color;
            foreach (Point p in nums) {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write('$');
            }
        }
    }
}
