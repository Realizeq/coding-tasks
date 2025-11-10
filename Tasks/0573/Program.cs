using System;
class Program
{
    static void Main()
    {
        double max = double.MinValue;
        double min = double.MaxValue;

        Console.Write("количество людей: ");
        int n = int.Parse(Console.ReadLine());

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"человек {j}: ");
            double rost = double.Parse(Console.ReadLine());

            if (rost > max) max = rost;
            if (rost < min) min = rost;
        }

        double difference = max - min;
        Console.WriteLine($"разница: {difference} см");
    }
}