using System;

class Program
{
    static bool Proverka(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        Console.WriteLine("Введите число:");
        int num = Convert.ToInt32(Console.ReadLine());

        bool isproverka = Proverka(num);

        if (isproverka)
        {
            Console.WriteLine($"{num} - простое число.");
        }
        else
        {
            Console.WriteLine($"{num} - не простое число.");
        }
    }
}
