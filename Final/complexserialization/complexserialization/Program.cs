using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace complexserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            complex A = new complex(0, 0);
            string str = Console.ReadLine();
            string[] arr = str.Split();
            foreach(string i in arr)
            {
                A.x += int.Parse(i);
                A.y += int.Parse(i);
            }
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("complex.ser",FileMode.OpenOrCreate, FileAccess.Write);
            bf.Serialize(fs, A);
            fs.Close();
            Console.ReadKey();
            FileStream fr = new FileStream("complex.ser", FileMode.Open, FileAccess.Read);
            complex B=bf.Deserialize(fr) as complex;
            fr.Close();
            Console.WriteLine(B);
            Console.ReadKey();
        }
    }
}
