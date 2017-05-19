using System.IO;
using System.Collections.Generic;
using System;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"papka";
            Stack<DirectoryInfo> dir = new Stack<DirectoryInfo>();
            dir.Push(new DirectoryInfo(path));

            while (dir.Count != 0)
            {
                DirectoryInfo dil = dir.Pop();
                foreach(DirectoryInfo p in dil.GetDirectories())
                {
                    Console.WriteLine(p.Name);
                    dir.Push(p);
                }
                foreach(FileInfo r in dil.GetFiles())
                {
                    Console.WriteLine(r.Name);
                }

            }
            Console.ReadKey();
        }
    }
}
