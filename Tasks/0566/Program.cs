using System;
class Program
{
    static void Main()
    {
        double max = double.MinValue;

        Console.Write("количество дней: ");
        int n = int.Parse(Console.ReadLine());

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"день {j}: ");
            double temp = double.Parse(Console.ReadLine());

            if (temp > max) max = temp;
        }

        Console.WriteLine($"максимальная температура: {max}");
    }
}