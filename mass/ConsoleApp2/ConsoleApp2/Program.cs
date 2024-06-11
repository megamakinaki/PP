using System;

namespace StringArraySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "Витя", "Ваня", "Артем", "Вова", "Саша" };

            Console.WriteLine("Введите имя");
            string userInput = Console.ReadLine();

            bool stringFound = false;

            foreach (string str in strings)
            {
                if (str == userInput)
                {
                    stringFound = true;
                    break;
                }
            }

            if (stringFound)
            {
                Console.WriteLine("Имя найдено в массиве!");
            }
            else
            {
                Console.WriteLine("Имя не найдено в массиве!");
            }
        }
    }
}
