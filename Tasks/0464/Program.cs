using System;
class Program
{
    static void Main()
    {
        double totalWheat = 0;
        double totalArea = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"район {i} - площадь: ");
            double area = double.Parse(Console.ReadLine());

            Console.Write($"район {i} - урожайность: ");
            double yield = double.Parse(Console.ReadLine());

            totalWheat += area * yield;
            totalArea += area;
        }

        double averageYield = totalWheat / totalArea;

        Console.WriteLine($"общее количество пшеницы: {totalWheat}");
        Console.WriteLine($"средняя урожайность: {averageYield}");
    }
}