using System;
class Program
{
    static void Main()
    {
        double best = double.MaxValue;

        Console.Write("количество спортсменов: ");
        int n = int.Parse(Console.ReadLine());

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"спортсмен {j}: ");
            double time = double.Parse(Console.ReadLine());

            if (time < best) best = time;

            Console.WriteLine($"лучший результат: {best}");
        }
    }
}