using System;

public class Program
{
    public static void Main()
    {
        int num1 = 5;
        int num2 = 10;

        int result = Sum(num1, num2);
        Console.WriteLine("Сумма чисел " + num1 + " и " + num2 + " равна " + result);
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}
