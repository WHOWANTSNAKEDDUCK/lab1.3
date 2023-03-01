// НЕРЕШИЛ!!!!!!!!!!!!!!!!!!!

//На числовой оси расположены три точки: A, B, C.
//Определить, какая из двух последних точек (B или C) расположена ближе к A,
//и вывести эту точку и ее расстояние от точки A.

using System;

namespace if20
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c");
            int c = Convert.ToInt32(Console.ReadLine());
          if ((a - b) < 0)
            {
                Console.WriteLine("Точка B ближе к A .Расстяние до точки A =  " + (a - c));
            }
            else if ((a - c) < 0)
            {
                Console.WriteLine("Точка С ближе к A .Расстяние до точки A =  " + ((a - c) * -1));


            }
          else
            {
                Console.WriteLine("Вводимые числа не удовлетворяют условию задачи");
            }
        }
    }
}