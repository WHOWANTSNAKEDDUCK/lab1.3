// Для данного вещественного x найти значение следующей функции f,
// принимающей вещественные значения (+написать модульный тест):

using System;

namespace If26
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите X");
            Double x = Convert.ToDouble(Console.ReadLine());
            Double f;
            if(x <= 0)
            {
                f = -x;
                Console.WriteLine("F(" + x + ") =" + f);
            }
            else if(0 < x && x<2)
            {
                f = Math.Pow(x, 2);
                Console.WriteLine("F(" + x + ") =" + f);
            }
            else if(x >= 2)
            {
                f = 4;
                Console.WriteLine("F(" + x + ") =" + f);
            }
        }
    }
}
