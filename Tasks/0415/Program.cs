using System;
class Program
{
    static void Main()
    {
        int a = 425;
        int b = 131;

        Console.WriteLine($"исходный прямоугольник: {a} на {b}");
        Console.WriteLine("квадраты:");

        while (a > 0 && b > 0)
        {
            if (a >= b)
            {
                int count = a / b;
                Console.WriteLine($"{b} на {b} - {count}");
                a = a % b;
            }
            else
            {
                int count = b / a;
                Console.WriteLine($"{a} на {a} - {count}");
                b = b % a;
            }
        }
    }
}