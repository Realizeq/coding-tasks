using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите год: ");
        int n = int.Parse(Console.ReadLine());

        if (n % 400 == 0)
        {
            Console.WriteLine($"{n} год является високосным");
        }
        else if (n % 100 == 0)
        {
            Console.WriteLine($"{n} год не является високосным");
        }
        else if (n % 4 == 0)
        {
            Console.WriteLine($"{n} год является високосным");
        }
        else
        {
            Console.WriteLine($"{n} год не является високосным");
        }
    }
}