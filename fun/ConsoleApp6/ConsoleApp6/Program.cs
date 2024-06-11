using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        if (Pal(input))
        {
            Console.WriteLine("Введенная строка является палиндромом.");
        }
        else
        {
            Console.WriteLine("Введенная строка не является палиндромом.");
        }
    }

    static bool Pal(string str)
    {
        str = str.ToLower().Replace(" ", ""); 
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false; 
            }
            left++;
            right--;
        }

        return true; 
    }
}
