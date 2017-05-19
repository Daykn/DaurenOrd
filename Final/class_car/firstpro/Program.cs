using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstpro
{
    class Program
    {
       class car{
        public string owner;
        public string model;
        public int year;

            public car(string owner,string model, int year)
            {
                this.owner = owner;
                this.model = model;
                this.year = year;
            }
            public override string ToString()
            {
                return owner + " " + model + " " + year;
            }
        }
 
    static void Main(string[] args)
    {
            Console.CursorVisible = false;
            car d = new car("Dave", "h5", 12);
            Console.WriteLine(d.ToString());
            Console.ReadKey();
    }
}
}

