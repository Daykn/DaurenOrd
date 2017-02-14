using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сlass_student
{
    class Program
    {
        class Student {
            public string name;
            public string sname;
            public int age;
            public int GPA;
            public int tel;

            public Student(string name, string sname, int age, int GPA,int tel) {
                this.name = name;
                this.sname = sname;
                this.age = age;
                this.GPA = GPA;
                this.tel = tel;
            }
            public override string ToString() {
                return name + " " + sname + " " + age + " " + GPA+" "+tel;
            }
        }
            
        static void Main(string[] args)
        {
            Student s = new Student("Ali", "ping", 21, 4,877);
            Console.WriteLine(s.ToString());
            Console.ReadKey();
        }
    }
}
