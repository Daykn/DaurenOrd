using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace StreamReaderWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"a.txt", FileMode.OpenOrCreate,FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            StreamWriter wr = new StreamWriter(@"b.txt");

            string str = sr.ReadToEnd();
            string[] arr = str.Split();
            foreach(string p in arr)
            {
                if (int.Parse(p) % 2 == 0)
                {
                    wr.Write(p+" ");
                }
            }
            sr.Close();
            wr.Close();
        }
    }
}
