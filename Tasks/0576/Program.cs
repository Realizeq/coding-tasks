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
            double massa = double.Parse(Console.ReadLine());

            if (massa > max) max = massa;
            if (massa < min) min = massa;
        }

        if (max > min * 2) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}