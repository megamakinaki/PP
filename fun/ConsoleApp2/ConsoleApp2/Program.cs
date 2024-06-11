using System;

class Program
{
    static double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    static void Main()
    {
        Console.WriteLine("Введите радиус окружности:");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = CalculateCircleArea(radius);

        Console.WriteLine($"Площадь окружности: {area}");
    }
}
