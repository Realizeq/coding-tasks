using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());

        int m = rand.Next(1, 21);
        int n = rand.Next(1, 21);

        Console.WriteLine($"m = {m}, n = {n}");

        Console.WriteLine($"{n} целых чисел от {a} до {b}:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(rand.Next(a, b + 1));
        }

        Console.WriteLine($"{m} вещественных чисел от 0 до {n}:");
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine(n * rand.NextDouble());
        }
    }
}