using System;
class Program
{
    static void Main()
    {
        int password;
        do
        {
            Console.Write("Введите пароль: ");
            password = int.Parse(Console.ReadLine());
            if (password != 1234)
            {
                Console.WriteLine("Ошибка неверный пароль");
            }
        } while (password != 1234);

        Console.WriteLine("Правильный пароль");
    }
}