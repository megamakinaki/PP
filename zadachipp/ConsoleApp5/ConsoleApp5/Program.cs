using System;
class ShetSlov
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string[] textMass;
        string text = Console.ReadLine();
        textMass = text.Split(' ');
        Console.WriteLine("Количество слов:");
        Console.WriteLine(textMass.Length);
    }
}
