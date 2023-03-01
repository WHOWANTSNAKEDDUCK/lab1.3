//Дано целое число. Если оно является положительным,
//то вычесть из него 8; если отрицательным, то прибавить к нему 6;
//если нулевым, то заменить его на 10. Вывести полученное число.

using System;

namespace if3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите чсило:");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num > 0)
            {
                num = num - 8;
                Console.WriteLine(num);
            }
            else if(num < 0)
            {
                num = num + 6;
                Console.WriteLine(num);
            }
            else
            {
                num = 10;
                Console.WriteLine(num);
            }
        }
    }
}
