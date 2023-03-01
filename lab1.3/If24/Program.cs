//Для данного вещественного x найти значение следующей функции f,
//принимающей вещественные значения (+написать модульный тест):

using System;

namespace If24
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите X");
            int x = Convert.ToInt32(Console.ReadLine());
            Double f;
            if ( x > 0)
            {
                f = (2 * Math.Sin(x));
                Console.WriteLine("F(" + x + ") =" + f);
            }
            else if(x <= 0)
            {
                f = (6 - x);
                Console.WriteLine("F(" + x + ") =" + f);
            }
        }
    }
}
