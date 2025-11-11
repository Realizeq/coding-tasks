using System;
class Program
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        double max_avg = 0;
        int max_index = 0;

        double min_geom = double.MaxValue;
        int min_index = 0;

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"пара {j} - a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write($"пара {j} - b: ");
            double b = double.Parse(Console.ReadLine());

            // а)
            double avg = (a + b) / 2;
            if (avg >= max_avg)
            {
                max_avg = avg;
                max_index = j;
            }

            // б)
            double geom = Math.Sqrt(a * b);
            if (geom < min_geom)
            {
                min_geom = geom;
                min_index = j;
            }
        }

        Console.WriteLine($"а) последняя пара с максимальным средним арифметическим: {max_index}");
        Console.WriteLine($"б) первая пара с минимальным средним геометрическим: {min_index}");
    }
}