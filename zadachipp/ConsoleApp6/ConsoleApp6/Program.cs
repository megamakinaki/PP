using System;
using System.Text;
class PasswordGenerator
{
    static void Main()
    {
        Console.Write("Введите длину пароля: ");
        int length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(GeneratePassword(length));
    }
    static string GeneratePassword(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_=+;:,.?";
        StringBuilder password = new StringBuilder();
        Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            int index = random.Next(chars.Length);
            password.Append(chars[index]);
        }
        return password.ToString();
    }
}
