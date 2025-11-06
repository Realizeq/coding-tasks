using System;
class Program
{
    static void Main()
    {
        int count = 0;

        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"тройка {i} - a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write($"тройка {i} - b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write($"тройка {i} - c: ");
            int c = int.Parse(Console.ReadLine());

            if (a + b > c) count++;
        }

        Console.WriteLine($"троек для треугольника: {count}");
    }
}