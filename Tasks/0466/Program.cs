using System;
class Program
{
    static void Main()
    {
        double totalArea = 0;

        for (int i = 1; i <= 12; i++)
        {
            Console.Write($"район {i} - жители: ");
            double people = double.Parse(Console.ReadLine());

            Console.Write($"район {i} - плотность: ");
            double density = double.Parse(Console.ReadLine());

            totalArea += people / density;
        }

        Console.WriteLine($"общая площадь: {totalArea}");
    }
}