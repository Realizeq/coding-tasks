using System;
class Program
{
    static void Main()
    {
        double max = double.MinValue;
        double min = double.MaxValue;

        for (int j = 1; j <= 15; j++)
        {
            Console.Write($"x{j}: ");
            double x = double.Parse(Console.ReadLine());

            if (x > max) max = x;
            if (x < min) min = x;
        }

        Console.WriteLine($"а) максимальное: {max}");
        Console.WriteLine($"б) минимальное: {min}");
        Console.WriteLine($"в) максимальное: {max}, минимальное: {min}");
    }
}