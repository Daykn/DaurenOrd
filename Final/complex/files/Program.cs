using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace files
{
    class complex
    {
        public int x, y;

        public complex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        static int gcd(int z, int x)
        {
            z = Math.Abs(z);
            x = Math.Abs(x);
            for (int i = Math.Min(z, x); i > 1; i--)
            {
                if (z % i == 0 & x % i == 0)
                {
                    return i;
                }
            }
            return 1;
        }

        public static complex operator +(complex a, complex b)
        {
            complex add = new complex(a.x + b.x, a.y + b.y);
            return add;
        }
        public static complex operator -(complex a, complex b)
        {
            complex sub = new complex(a.x - b.x, a.y - b.y);
            return sub;
        }

        public override string ToString()
        {
            int g = gcd(x,y);
            return x/g + "/" + y/g;
        }
    }

    class Program
    { 
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] arr = str.Split();
            string[] S = arr[0].Split('/');
            complex plus = new complex(int.Parse(S[0]), int.Parse(S[1]));
            complex minus = new complex(int.Parse(S[0]), int.Parse(S[1]));

            for(int i = 1; i < arr.Length; i++)
            {
                string p = arr[i];
                string[] k = p.Split('/');

                complex A = new complex(int.Parse(k[0]), int.Parse(k[1]));
                plus = plus + A;
                minus = minus - A;
            }

            Console.WriteLine("plus = " + plus);
            Console.WriteLine("minus = "+minus);
            Console.ReadKey();
        }
    }
}
