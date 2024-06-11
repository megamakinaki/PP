using System;
using System.Linq;

namespace TemperatureWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            double avgTemp = 0;
            string[] dayOfWeek = new string[7] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            int[] tempOfDay = new int[7];
            Console.WriteLine($"Введите температуру воздуха за неделю: ");
            for (int i = 0; i < dayOfWeek.Length; i++)
            {
                Console.Write($"{dayOfWeek[i]} -> ");
                tempOfDay[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in tempOfDay)
                Console.Write($"{item} ");
            Console.WriteLine();
            foreach (var item in tempOfDay)
                avgTemp += item;
            avgTemp /= 7;
            Console.WriteLine($"Средняя температура за неделю: {Math.Round(avgTemp, 2)}");
            Console.WriteLine($"Максимальная температура: {dayOfWeek[Array.IndexOf(tempOfDay, tempOfDay.Max())]} - {tempOfDay.Max()}");
            Console.WriteLine($"Минимальная температура: {dayOfWeek[Array.IndexOf(tempOfDay, tempOfDay.Min())]} - {tempOfDay.Min()}");
        }
    }
}
