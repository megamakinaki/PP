﻿using System;

namespace ComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int number1 = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Введите второе число:");
            int number2 = Convert.ToInt32(Console.ReadLine()); 

            if (number1 == number2)
            {
                Console.WriteLine("Числа равны");
            }
            else if (number1 > number2)
            {
                Console.WriteLine($"Первое число больше второго числа");
            }
            else
            {
                Console.WriteLine($"Первое число меньше второго числа");
            }
        }
    }
}

