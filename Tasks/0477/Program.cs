using System;
class Program
{
    static void Main()
    {
        double total = 0;

        Console.Write("количество дней в месяце: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"день {i}: ");
            double osadki = double.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                total += osadki;
            }
        }

        Console.WriteLine($"общее количество осадков в четные дни: {total}");
    }
}