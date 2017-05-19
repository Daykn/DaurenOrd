using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenum
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] arr = str.Split();
            
                foreach (string p in arr)
                {
                try
                {
                    int j = 0;
                    for (int i = 2; i < int.Parse(p); i++)
                    {
                        if (int.Parse(p) % i == 0)
                            j++;
                    }
                    if (j == 0)
                        Console.Write(p + " ");
                }
                catch(Exception e)
                {
                    Console.WriteLine("Error "+p);
                }
                }

            
            
            

            

            Console.ReadKey();
        }
    }
}
