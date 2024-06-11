using System;

class Program
{
    static int FindMaxValue(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Массив не может быть пустым");
        }

        int max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }

    static void Main()
    {
        int[] numbers = { 10, 5, 20, 15, 8 };
        int maxValue = FindMaxValue(numbers);

        Console.WriteLine("Наибольшее значение в массиве: " + maxValue);
    }
}
