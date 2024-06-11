using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[,] numbers = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int sum = CalculateSum(numbers);
        Console.WriteLine("Сумма всех элементов в двумерном массиве: " + sum);
    }

    public static int CalculateSum(int[,] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[i, j];
            }
        }
        return sum;
    }
}
