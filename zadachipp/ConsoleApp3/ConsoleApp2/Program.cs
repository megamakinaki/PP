using System;
class AgeCalculator
{
    static void Main()
    {
        Console.WriteLine("Введите дату рождения (ДД.ММ.ГГГГ): ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());

        DateTime currentDate = DateTime.Now;
        TimeSpan age = currentDate - birthDate;

        int years = currentDate.Year - birthDate.Year;
        int months = currentDate.Month - birthDate.Month;
        int days = currentDate.Day - birthDate.Day;

        if (months < 0 || (months == 0 && days < 0))
        {
            years--;
            months += 12;
        }
        if (days < 0)
        {
            months--;
            days += DateTime.DaysInMonth(birthDate.Year, birthDate.Month);
        }

        Console.WriteLine($"Ваш возраст: {years} лет, {months} месяцев и {days} дней");
    }
}