using System;

class Program
{
    static long Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Введено отрицательное число");
        }

        long result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine("Введите число: ");
        int input = int.Parse(Console.ReadLine());

        long factorial = Factorial(input);

        Console.WriteLine("Факториал числа " + input + " равен " + factorial);
    }
}
