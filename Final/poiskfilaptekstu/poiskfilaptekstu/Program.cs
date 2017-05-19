using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace poiskfilaptekstu
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "asd";

            DirectoryInfo dir = new DirectoryInfo(@"papka");
            foreach (FileInfo p in dir.GetFiles())
            {
                StreamReader sr = new StreamReader(p.FullName);
                string str1 = sr.ReadToEnd();
                string[] arr = str1.Split();
                foreach(string a in arr)
                {
                    if(a==str)
                        Console.WriteLine(p.Name);
                }   
            }
            Console.ReadKey();
        }
    }
}
