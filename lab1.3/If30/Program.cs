//Дано целое число, лежащее в диапазоне 1–999.
//Вывести его строку-описание вида «четное двузначное число», «нечетное трехзначное число» и т. д.

using System;

namespace If30
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите X");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x < 1 || x > 999)
            {
                Console.WriteLine("Число не соответсуют условию задачи");
            }
            else if ( x / 100 > 0 && x / 100 < 10)
            {
                if( x % 2 == 0)
                {
                    Console.WriteLine("Число четное, трехзначное");
                }
                else
                {
                    Console.WriteLine("Число нечетное, трехзначное");
                }
            }
            else if (x / 10 > 0 && x / 10 < 10)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine("Число четное, двухзначное");
                }
                else
                {
                    Console.WriteLine("Число нечетное, двухзначное");
                }
            }
        }
    }
}
