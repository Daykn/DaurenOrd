using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coomplex1
{
    
    }
    class complex//make class
    {
        public int x;
        public int y;
        public bool isValid;

        public complex(int x, int y)//structure of the class
        {
            if (y == 0)
                isValid = false;
            else
            {
                this.x = x;
                this.y = y;
                isValid = true;
            }
        }
        static int gcd1(int l, int t)//gcd1 это  дробь который мы поделим на наибольший общий делитель
        {
            l = Math.Abs(l);
            t = Math.Abs(t);
            for (int i = Math.Min(l, t); i > 1; i--)//заводим фор для того чтобы пробежаться от меньшего значения дроби(l/t)либо l либо t, до 1
            {
                if (l % i == 0 && t % i == 0)//если в процессе пробежки появилось число на которое деляться оба числа(числитель,знаменатель),
                    
                {
                    return i;//то возвращаем его
                }
            }
            return 1;//если наибольший делитель не нашелся то возвращаем обратно свое значение деля на 1
        }
    
        public static complex operator +(complex a, complex b)//прописываем свойство для знака "+"
        {
            complex add = new complex(1, 1);
                int w = a.y * b.y;//в данном случае находим его просто умножая знаменатели 
            
            if (a.x == 0 && a.y == 0) {
                add.x = b.x;
                add.y = b.y;
            }
            if (b.x == 0 && b.y == 0)
            {
                add.x = a.x;
                add.y = a.y;
            }
            if (a.x == 0 || b.x == 0) {
                add.x = 0;
                add.y = 0;
            }
            add.y = w;//тут получаем знаменатель
                a.x = a.x*(w / a.y);//тут и на строке ниже изза изменения знаменателя меняються и числители 
                b.x = b.x*(w / b.y);
                add.x = a.x * b.y + b.x * a.y;//тут получаем числитель

            return add;//возвращаем ответ
        }
        public static complex operator -(complex a, complex b)//проделываемвсе все тоже самое но со знаком "-"
        {
            complex sub = new complex(1,1);
            
            if (a.y == b.y) {
                sub.y = a.y;
                sub.x = a.x - b.x;
            }
            if (a.x == 0 && a.y == 0)
            {
                sub.x = b.x;
                sub.y = b.y;
            }
            if (b.x == 0 && b.y == 0)
            {
                sub.x = a.x;
                sub.y = a.y;
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
        
        public static complex operator /(complex a, complex b)
        {//при умножении просто умножаем
            complex div = new complex(1,1);
            div.x = a.x * b.y;
            div.y = a.y * b.x;
            if (a.x == 0 || b.x == 0)
            {//если один из числителей равен 0 то ответ тоже равен 0
                div.x = 0;
                div.y = 0;
            }
            return div;
        }
        public static complex operator *(complex a,complex b)
        {//приделении умножаем на противоположные значения
            complex mult = new complex(1,1);
            mult.x = a.x * b.x;
            mult.y = a.y * b.y;
            if (a.x == 0 || b.x == 0)
            {//если один из числителей равен 0 то ответ тоже равен 0
                mult.x = 0;
                mult.y = 0;
            }
            return mult;
        }
        public override string ToString()
        {
            /*а тут мы пишем как ответ должен выходить */

            int g=gcd1(x, y);//это наибольший общий делитель 
            return (x/g)+"/"+(y/g);
        }


    }
    class Program
    {
        
        static void Main(string[] args)
        {
            
            complex mult = new complex(1,1);//начальное значение умножения(тоесть умножаем начиная с 1,1)


            string str = Console.ReadLine();//пишем вводные данные, например:"16/4 2/4"
            string[] arr = str.Split( );//разделяем их по пробелу и сохраняем в массив 
            string Z = arr[0]; 
            string[] S = Z.Split('/');
            
            complex div = new complex(int.Parse(S[0]),int.Parse(S[1]));
            complex plus = new complex(0, 0);
            complex minus = new complex(0, 0);
        
            for (int i = 1; i < arr.Length; i++) {
                
                    String p = arr[i];
                    string[] k = p.Split('/');
            if (isValid(k[1]) == true)
            {
                complex A = new complex(int.Parse(k[0]), int.Parse(k[1]));
                    mult = mult * A;
                    complex B = new complex(int.Parse(k[0]), int.Parse(k[1]));
                    div = div / B;
                    complex C = new complex(int.Parse(k[0]), int.Parse(k[1]));
                    plus = C + plus;
                    complex D = new complex(int.Parse(k[0]), int.Parse(k[1]));
                    minus = minus - D;
                }

            }


            /*string[] f = arr[0].Split('/');//потом первый элемент нашего массива делим по "/" и опять сохраняем в другой массив
            complex A = new complex(int.Parse(f[0]),int.Parse(f[1]));
         
            string[] s = arr[1].Split('/');
            complex B = new complex(int.Parse(s[0]), int.Parse(s[1]));
            */
            Console.WriteLine("mul: " + mult);
            Console.WriteLine("div: " + div);
            Console.WriteLine("plus: " + plus);
            Console.WriteLine("minus : " + minus);
            /*выводим ответ*/
            Console.ReadKey();
        }
    }

