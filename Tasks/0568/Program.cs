using System;
class Program
{
    static void Main()
    {
        double min_radius = double.MaxValue;

        Console.Write("количество кругов: ");
        int n = int.Parse(Console.ReadLine());

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"круг {j} - площадь: ");
            double area = double.Parse(Console.ReadLine());

            double radius = Math.Sqrt(area / Math.PI);
            if (radius < min_radius) min_radius = radius;
        }

        Console.WriteLine($"радиус самого маленького: {min_radius}");
    }
}