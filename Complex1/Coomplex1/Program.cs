using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coomplex1
{

    class complex
    {
        public int x;
        public int y;

        public complex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        static int gcd1(int l, int t)
        {

            for (int i = Math.Min(l, t); i > 1; i--)
            {

                if (Math.Max(l, t) % i == 0 && Math.Min(l, t) % i == 0)
                {
                    l = l / i;

                    break;
                }


            }
            return l;
        }
            static int gcd2(int l, int t) {

                for (int i = Math.Min(l, t); i > 1; i--)
                {

                    if (Math.Max(l, t) % i == 0 && Math.Min(l, t) % i == 0)
                    {
                        t = t / i;

                        break;
                    }


                }
                return t;

            }
        public static complex operator +(complex a, complex b) {
            complex add = new complex(0, 0);
            if (a.y == b.y) {
                add.x = a.x + b.x;
                add.y = a.y;
            }
            if (a.y != b.y) {
                int w = a.y * b.y;
                add.y = w;
                a.x = a.x*(w / a.y);
                b.x = b.x*(w / b.y);
                add.x = a.x + b.x;
                
            }
            return add;
        }
        public static complex operator -(complex a, complex b) {
            complex sub = new complex(0,0);
            if (a.y == b.y) {
                sub.y = a.y;
                sub.x = a.x - b.x;
            }
            if (a.y != b.y) {
                int w = a.y * b.y;
                sub.y = a.y;
                a.x = a.x * (w / a.y);
                b.x = b.x * (w / b.y);
                sub.x = a.x - b.x;
            }
            return sub;
            }
        

        public static complex operator /(complex a, complex b) {
            complex div = new complex(1,1);
            div.x = a.x * b.y;
            div.y = a.y * b.x;
            return div;
        }
        public static complex operator *(complex a,complex b)
        {
            complex mult = new complex(1,1);
            mult.x = a.x * b.x;
            mult.y = a.y * b.y;
            return mult;
        }
        public override string ToString()
        {
            /* int g = gcd(this.x, this.y);
             return (x / g) + "/" + (y / g);*/

            int h=gcd1(x, y);
            int j = gcd2(x, y);
            return h+"/"+j;
        }


    }
    class Program
    {
        
        static void Main(string[] args)
        {
            
            string str = Console.ReadLine();
            string[] arr = str.Split( );
            string[] f = arr[0].Split('/');
            complex A = new complex(int.Parse(f[0]),int.Parse(f[1]));
         
            string[] s = arr[1].Split('/');
            complex B = new complex(int.Parse(s[0]), int.Parse(s[1]));

            Console.WriteLine("add: " + (A + B));
            Console.WriteLine("sub: " + (A - B));
            Console.WriteLine("mul: " + (A * B));
            Console.WriteLine("div: " + (A / B));

            Console.ReadKey();
        }
    }
}
