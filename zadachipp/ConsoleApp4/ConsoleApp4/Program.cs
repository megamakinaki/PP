using System;
class Timer
{
    static void Main()
    {
        Console.Write("Количество секунд до взрыва: ");
        int sec = int.Parse(Console.ReadLine());
        int now = 0;
        while (sec > -1)
        {
            if (now != DateTime.Now.Second)
            {
                Console.WriteLine($"Осталось секунд: {sec--}");
                now = DateTime.Now.Second;
            }
        }
        Console.WriteLine("Взрыв!");
        Console.Read();
    }
}
