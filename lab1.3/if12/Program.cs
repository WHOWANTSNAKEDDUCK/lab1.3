//Даны три числа. Найти наименьшее из них.
using System;

namespace if12
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введие число 1/3:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введие число 2/3:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введие число 3/3:");
            int c = Convert.ToInt32(Console.ReadLine());
            if(a < b && a < c)
            {
                Console.WriteLine("Наименьшее число: " + a);
            }
          else if( c < a && c < b)
            {
                Console.WriteLine("Наименьшее число: " + c);
            }
            else
            {
                Console.WriteLine("Наименьшее число: " + b);
            }
        }
        }
    }

