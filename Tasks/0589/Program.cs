using System;
class Program
{
    static void Main()
    {
        double max_osadki = 0;
        int max_day = 0;

        Console.Write("количество дней в месяце: ");
        int n = int.Parse(Console.ReadLine());

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"день {j}: ");
            double osadki = double.Parse(Console.ReadLine());

            if (osadki >= max_osadki)
            {
                max_osadki = osadki;
                max_day = j;
            }
        }

        Console.WriteLine($"самое большое количество осадков выпало {max_day} числа");
    }
}