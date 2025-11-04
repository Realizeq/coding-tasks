using System;
class Program
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("p: ");
        double p = double.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"d{i}: ");
            double d = double.Parse(Console.ReadLine());

            if (d > 20.5) sum += d;
        }

        if (sum < p) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}