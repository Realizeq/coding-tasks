using System;
class Program
{
    static void Main()
    {
        double max = 0;

        Console.Write("количество городов: ");
        int n = int.Parse(Console.ReadLine());

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"город {j}: ");
            double dist = double.Parse(Console.ReadLine());

            if (dist > max) max = dist;
        }

        Console.WriteLine($"самый удаленный город: {max} км");
    }
}