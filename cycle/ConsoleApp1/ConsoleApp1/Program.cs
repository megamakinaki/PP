using System;

namespace DepositCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада: ");
            decimal deposit = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите кол-во месяцев: ");
            int months = Convert.ToInt32(Console.ReadLine());

            decimal interestRate = 0.07m;

            for (int month = 1; month <= months; month++)
            {
                deposit += deposit * interestRate;
            }

            Console.WriteLine($"Итоговая сумма вклада через {months} месяцев: {deposit}");
        }
    }
}