using System;
class Program
{
    static void Main()
    {
        Console.Write("количество учеников в классе: ");
        int n = int.Parse(Console.ReadLine());

        double sum1 = 0;
        double sum2 = 0;

        Console.WriteLine("рост учеников первого класса:");
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"ученик {i}: ");
            double rost = double.Parse(Console.ReadLine());
            sum1 += rost;
        }

        Console.WriteLine("рост учеников второго класса:");
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"ученик {i}: ");
            double rost = double.Parse(Console.ReadLine());
            sum2 += rost;
        }

        double srednee1 = sum1 / n;
        double srednee2 = sum2 / n;

        Console.WriteLine($"средний рост первого класса: {srednee1}");
        Console.WriteLine($"средний рост второго класса: {srednee2}");
    }
}