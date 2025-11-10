using System;
class Program
{
    static void Main()
    {
        double min_density = double.MaxValue;

        for (int j = 1; j <= 16; j++)
        {
            Console.Write($"государство {j} - население (млн): ");
            double people = double.Parse(Console.ReadLine());

            Console.Write($"государство {j} - площадь (тыс.км2): ");
            double area = double.Parse(Console.ReadLine());

            double density = people / area;

            if (density < min_density) min_density = density;
        }

        Console.WriteLine($"минимальная плотность: {min_density} млн/тыс.км2");
    }
}