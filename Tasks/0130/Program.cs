using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int n = int.Parse(Console.ReadLine());

        if (m % n == 0)
        {
            int result = m / n;
            Console.WriteLine($"Частное от деления: {result}");
        }
        else
        {
            Console.WriteLine($"{m} на {n} нацело не делится");
        }
    }
}