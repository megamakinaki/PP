using System;

namespace BankDeposit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада: ");
            double deposit = Convert.ToDouble(Console.ReadLine());
            double total = deposit;

            if (deposit < 100)
            {
                total += deposit * 0.05; 
            }
            else if (deposit >= 100 && deposit <= 200)
            {
                total += deposit * 0.07; 
            }
            else
            {
                total += deposit * 0.10; 
            }

            Console.WriteLine($"Сумма вклада с учетом процентов: {total}");
        }
    }
}