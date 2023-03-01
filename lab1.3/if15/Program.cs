//Даны три числа. Найти сумму двух наибольших из них.

using System;

namespace if15
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Введите первое число:");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите тертье число:");
            c = Convert.ToInt16(Console.ReadLine());
            if (b <= c && b <= a)
            {
                Console.WriteLine("Сумма двух наибольших: " + (a + c));
            }
            else if (a <= c && a <= b)
            {
                Console.WriteLine("Сумма двух наибольших: " + (b + c));
            }
            else
            {
                Console.WriteLine("Сумма двух наибольших: " + (b + a));
            }
        }
    }
}
