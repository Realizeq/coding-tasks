using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите число b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Введите число c: ");
        int c = int.Parse(Console.ReadLine());

        Console.Write("Введите число d: ");
        int d = int.Parse(Console.ReadLine());

        int remainder = a % b;

        if (remainder == c || remainder == d)
        {
            Console.WriteLine($"Остаток от деления {a} на {b} равен {c} или {d}");
        }
        else
        {
            Console.WriteLine($"Остаток от деления {a} на {b} не равен {c} или {d}");
        }
    }
}