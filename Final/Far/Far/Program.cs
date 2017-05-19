using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Far
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo place = new DirectoryInfo(@"D:\\");
            Stack<DirectoryInfo> path = new Stack<DirectoryInfo>();
            path.Push(place);

            DirectoryInfo dir = path.Peek();

            List<FileSystemInfo> list = new List<FileSystemInfo>();
            list.AddRange(dir.GetDirectories());
            list.AddRange(dir.GetFiles());
            int cursor = 0;

            while (true)
            {
                for(int i = 0; i < list.Count; i++)
                {
                    if (cursor == i)
                        Console.BackgroundColor = ConsoleColor.Gray;
                    else
                        Console.BackgroundColor = ConsoleColor.Black;
                    if (list[i].GetType() == typeof(FileInfo))
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine(list[i].Name);
                }

                ConsoleKeyInfo pressedkey = Console.ReadKey();
                switch (pressedkey.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (cursor < list.Count - 1)
                            cursor++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (cursor > 1)
                            cursor--;
                        break;
                    case ConsoleKey.Enter:
                        if (list[cursor].GetType() == typeof(DirectoryInfo))
                        {
                            path.Push(new DirectoryInfo(list[cursor].FullName));
                            dir = new DirectoryInfo(list[cursor].FullName);
                            list.Clear();
                            list.AddRange(dir.GetDirectories());
                            list.AddRange(dir.GetFiles());
                        }
                        else
                        {
                            Console.Clear();
                            StreamReader sr = new StreamReader(list[cursor].FullName);
                            string str = sr.ReadToEnd();
                            sr.Close();
                            Console.WriteLine(str);
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.Escape:
                        if (path.Count > 1)
                        {
                            path.Pop();
                            dir = path.Peek();
                            list.Clear();
                            list.AddRange(dir.GetDirectories());
                            list.AddRange(dir.GetFiles());
                        
                }
                        cursor = 0;
                        break;
                }
                Console.Clear();
            }
        }
    }
}
