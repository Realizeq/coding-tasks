using System;
class Program
{
    static void Main()
    {
        Console.Write("количество учеников в классе: ");
        int n = int.Parse(Console.ReadLine());

        double sum1 = 0;
        double sum2 = 0;

        Console.WriteLine("оценки по физике первого класса:");
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"ученик {i}: ");
            double ocenka = double.Parse(Console.ReadLine());
            sum1 += ocenka;
        }

        Console.WriteLine("оценки по физике второго класса:");
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"ученик {i}: ");
            double ocenka = double.Parse(Console.ReadLine());
            sum2 += ocenka;
        }

        double srednee1 = sum1 / n;
        double srednee2 = sum2 / n;

        Console.WriteLine($"средняя оценка первого класса: {srednee1}");
        Console.WriteLine($"средняя оценка второго класса: {srednee2}");
    }
}