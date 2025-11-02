using System;
class Program
{
    static void Main()
    {
        double sum1 = 0;
        double sum2 = 0;

        Console.WriteLine("возраст учеников первого класса");
        for (int i = 1; i <= 20; i++)
        {
            Console.Write($"ученик {i}: ");
            double vozrast = double.Parse(Console.ReadLine());
            sum1 += vozrast;
        }

        Console.WriteLine("возраст учеников второго класса");
        for (int i = 1; i <= 20; i++)
        {
            Console.Write($"ученик {i}: ");
            double vozrast = double.Parse(Console.ReadLine());
            sum2 += vozrast;
        }

        double srednee1 = sum1 / 20;
        double srednee2 = sum2 / 20;

        Console.WriteLine($"средний возраст первого класса: {srednee1}");
        Console.WriteLine($"средний возраст второго класса: {srednee2}");
    }
}