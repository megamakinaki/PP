using System;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string userInput = Console.ReadLine();

        string reversString = Reverse(userInput);

        Console.WriteLine(reversString);
    }

    public static string Reverse(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
