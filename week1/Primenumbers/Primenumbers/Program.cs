using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primenumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();//создаем строку
            string[] arr = s.Split();//разделяет строку и заносит ее в массив
            foreach (string p in arr) {//создается функция for для каждого элемента массива
                try//эта функция позволяет хранить ошибки и при надобности показывать их
                {
                    int l = 0;//заводим итератор
                    for (int n = 1; n <= int.Parse(p); n++)//пробегаемся от 1 до каждого числа в нашем массиве 
                    {
                        if (int.Parse(p) % n == 0)//если число делится на наш второй итератор, мы увеличиваем первый итератор на 1
                        {
                            l++;
                        }
                    }
                    if (int.Parse(p) == 1)//или если оно равно 1 то мы просто выводим его, потомучто оно 2 раза на себя делиться не будет 
                    {
                        Console.WriteLine(p);
                    }
                    if (l == 2)
                    {
                        Console.WriteLine(p);
                    }
                }
                catch (Exception e) {//тут мы ловим ошибки ввода
                    Console.WriteLine("Error in parsing" + p);//а тут мы выводим их
                }
            }
            Console.ReadKey();//остановка программы нажатием на любую клавишу
        }
    }
}
