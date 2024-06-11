using System;

namespace ArraySumAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine("Сумма всех элементов массива: " + sum);
            Console.WriteLine("Среднее арифметическое всех чисел массива: " + average);
        }
    }
}
