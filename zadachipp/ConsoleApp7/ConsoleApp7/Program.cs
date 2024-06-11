using System;
class CurrencyConverter
{
    static void Main()
    {
        double S;
        double rate;
        Console.Write("Введите сумму: ");
        if (!double.TryParse(Console.ReadLine(), out S))
        {
            Console.WriteLine("Некорректно введена сумма");
            return;
        }
        Console.Write("Введите курс обмена (например, сколько стоит 1 единица валюты в другой): ");
        if (!double.TryParse(Console.ReadLine(), out rate))
        {
            Console.WriteLine("Некорректно введен курс обмена.");
            return;
        }
        double convertedSumma = S * rate;
        Console.WriteLine("Конвертированная сумма: " + convertedSumma);
    }
}

