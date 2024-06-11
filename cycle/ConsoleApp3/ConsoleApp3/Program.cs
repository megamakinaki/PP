using System;

namespace MultiplicationInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите 2 числа между 0 и 10:");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                if (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10)
                {
                    Console.WriteLine("Неверный ввод. Введите 2 числа между 0 и 10: ");
                }
                else
                {
                    int result = num1 * num2;
                    Console.WriteLine($"Произведение чисел {num1} и {num2} равняется: {result}");
                    break;
                }
            }
        }
    }
}
