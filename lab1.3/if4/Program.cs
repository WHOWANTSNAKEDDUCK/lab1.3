//Даны три целых числа. Найти количество положительных чисел в исходном наборе.
using System;

namespace if4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введие число 1/3:");
            int numA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введие число 2/3:");
            int numB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введие число 3/3:");
            int numC = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            if(numA > 0)
            {
                i ++;
            }
           if(numB > 0)
            {
                i++;
            }
            if(numC > 0)
            {
                i++;
            }
            Console.WriteLine("Колличество положительных чисел: " + i);

        }
    }
}
