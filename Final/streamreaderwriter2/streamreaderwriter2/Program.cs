using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace streamreaderwriter2
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo path = new DirectoryInfo(@"papka");

            foreach(FileSystemInfo p in path.GetFiles())
            {
                string str = p.Name;
                char[] arr = str.ToCharArray();
                foreach(char a in arr)
                {
                    if(a=='a')
                        Console.WriteLine(str);
                }
            }
            Console.ReadKey();
        }
    }
}
