using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace stack2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"1papka";
            Stack<DirectoryInfo> dir = new Stack<DirectoryInfo>();
            dir.Push(new DirectoryInfo(path));

            while (dir.Count != 0) {
                DirectoryInfo dil = dir.Pop();
                foreach (DirectoryInfo di in dil.GetDirectories()) {
                    Console.WriteLine(di.Name);
                    dir.Push(di);
                }
                foreach (FileInfo fi in dil.GetFiles())
                {
                    Console.WriteLine(fi.Name);
                    
                }
                
            }
            Console.ReadKey();
        }
        
    }
}