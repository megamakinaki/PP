using System;

namespace CelsiusToFahrenheitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double c;
            double f;
            Console.Write("Введите 1, если необходим перевод в Фаренгейты\r\nВведите 2, если необходим перевод в Цельсия:\r\n");
            int gr = Convert.ToInt32(Console.ReadLine());
            if (gr==1)
            {
                Console.WriteLine("Введите температуру в градусах Цельсия: ");
                c = Convert.ToDouble(Console.ReadLine());
                f = c * 1.8 + 32;
                Console.WriteLine("Температура в Фаренгейтах: " + f);
            }
            else
            {
                Console.WriteLine("Введите температуру в градусах Фаренгейта: ");
                f = Convert.ToDouble(Console.ReadLine());
                c = (f - 32) / 1.8;
                Console.WriteLine("Температура в Цельсия: " + c);
            }
        }
    }
}

