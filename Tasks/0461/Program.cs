using System;
class Program
{
    static void Main()
    {
        double sum1 = 0;
        double sum2 = 0;

        Console.WriteLine("осадки за январь:");
        for (int i = 1; i <= 31; i++)
        {
            Console.Write($"день {i}: ");
            double osadki = double.Parse(Console.ReadLine());
            sum1 += osadki;
        }

        Console.WriteLine("осадки за март:");
        for (int i = 1; i <= 31; i++)
        {
            Console.Write($"день {i}: ");
            double osadki = double.Parse(Console.ReadLine());
            sum2 += osadki;
        }

        double srednee1 = sum1 / 31;
        double srednee2 = sum2 / 31;

        Console.WriteLine($"среднее за январь: {srednee1}");
        Console.WriteLine($"среднее за март: {srednee2}");
    }
}