// Даны три числа. Найти среднее из них (т. е. число, расположенное между наименьшим и наибольшим).
using System;

namespace if13
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
        }
    }
}
