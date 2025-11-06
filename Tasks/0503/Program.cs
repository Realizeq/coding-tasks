using System;
class Program
{
    static void Main()
    {
        const double g = 9.8;
        int popadanie = 0;

        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("R: ");
        double R = double.Parse(Console.ReadLine());

        Console.Write("H: ");
        double H = double.Parse(Console.ReadLine());

        Console.Write("P: ");
        double P = double.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"выстрел {i} - α: ");
            double alpha = double.Parse(Console.ReadLine());

            Console.Write($"выстрел {i} - v0: ");
            double v0 = double.Parse(Console.ReadLine());

            double t = R / (v0 * Math.Cos(alpha * Math.PI / 180));
            double y = v0 * t * Math.Sin(alpha * Math.PI / 180) - g * t * t / 2;

            if (y >= H && y <= H + P) popadanie++;
        }

        double procent = (double)popadanie / n * 100;
        Console.WriteLine($"процент попадания: {procent}%");
    }
}