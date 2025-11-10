using System;
class Program
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        double[] t = new double[n];
        double[] c = new double[n];

        for (int j = 0; j < n; j++)
        {
            Console.Write($"t{j + 1}: ");
            t[j] = double.Parse(Console.ReadLine());
        }

        c[0] = 0;
        for (int j = 1; j < n; j++)
        {
            c[j] = c[j - 1] + t[j - 1];
        }

        double min_time = double.MaxValue;
        int min_index = 0;

        for (int j = 0; j < n; j++)
        {
            if (t[j] <= min_time)
            {
                min_time = t[j];
                min_index = j + 1;
            }
        }

        Console.WriteLine("время пребывания в очереди:");
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine($"c{j + 1}: {c[j]}");
        }

        Console.WriteLine($"номер последнего покупателя с минимальным временем обслуживания: {min_index}");
    }
}