using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class complex
    {
        public int x;
        public int y;
        public complex(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public static complex operator +(complex a,complex b)
        {
            complex d = new complex(a.x*b.y+a.y*b.x,a.y*b.y);
            return d;
        }
        public override string ToString()
        {
            return x+"/"+y;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] arr = str.Split('/', ' ');
            complex a = new complex(int.Parse(arr[0]),int.Parse(arr[1]));
            complex b = new complex(int.Parse(arr[2]), int.Parse(arr[3]));
            complex c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
