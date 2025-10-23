using System;
class Program
{
    static void Main()
    {
        float area = 100.0f;
        float yieldPerHectare = 20.0f;
        float totalHarvest = 0.0f;

        // а)
        Console.WriteLine("а) Урожайность:");
        for (int year = 1; year <= 8; year++)
        {
            if (year >= 2)
            {
                Console.WriteLine($"{year} год - {yieldPerHectare:F2} ц/га");
            }
            yieldPerHectare *= 1.02f;
        }

        // б)
        area = 100.0f;
        Console.WriteLine("б) Площадь участка:");
        for (int year = 1; year <= 7; year++)
        {
            if (year >= 4)
            {
                Console.WriteLine($"{year} год - {area:F2} га");
            }
            area *= 1.05f;
        }

        // в)
        area = 100.0f;
        yieldPerHectare = 20.0f;
        totalHarvest = 0.0f;
        for (int year = 1; year <= 6; year++)
        {
            totalHarvest += area * yieldPerHectare;
            area *= 1.05f;
            yieldPerHectare *= 1.02f;
        }
        Console.WriteLine($"в) Урожай за 6 лет - {totalHarvest:F2} ц");
    }
}