using System;

class Program
{
    static int GetStringLength(string inputString)
    {
        return inputString.Length;
    }

    static void Main()
    {
        string input = "Пример строки";
        int length = GetStringLength(input);

        Console.WriteLine("Длина строки: " + length);
    }
}
