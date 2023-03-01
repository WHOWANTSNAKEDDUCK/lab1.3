// Даны три числа. Вывести вначале наименьшее, а затем наибольшее из данных чисел.

using System;

namespace if14
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
            if (a < b && a < c)
            {
                Console.WriteLine("Наименьшее число: " + a);
            }
            else if (c < a && c < b)
            {
                Console.WriteLine("Наименьшее число: " + c);
            }
            else
            {
                Console.WriteLine("Наименьшее число: " + b);
            }

            if (a < b && a > c)
            {
                Console.WriteLine("Среднее число: " + a);
            }
            else if (c < a && c > b)
            {
                Console.WriteLine("Среднее число: " + c);
            }
            else
            {
                Console.WriteLine("Среднее число: " + b);
            }

            if (a > b && a > c)
            {
                Console.WriteLine("Наибольшее число: " + a);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("наибольшее число: " + c);
            }
            else
            {
                Console.WriteLine("Наибольшее число: " + b);
            }


        }
    }
}
