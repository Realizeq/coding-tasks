using System;
class Program
{
    static void Main()
    {
        double totalPeople = 0;
        double totalArea = 0;

        for (int i = 1; i <= 12; i++)
        {
            Console.Write($"район {i} - жители: ");
            double people = double.Parse(Console.ReadLine());

            Console.Write($"район {i} - площадь: ");
            double area = double.Parse(Console.ReadLine());

            totalPeople += people;
            totalArea += area;
        }

        double density = totalPeople / totalArea;

        Console.WriteLine($"средняя плотность: {density}");
    }
}