using System;
class Program
{
    static void Main()
    {
        double max_sum = double.MinValue;
        double min_prod = double.MaxValue;

        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"пара {j} - a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write($"пара {j} - b: ");
            double b = double.Parse(Console.ReadLine());

            double sum = a + b;
            double prod = a * b;

            if (sum > max_sum) max_sum = sum;
            if (prod < min_prod) min_prod = prod;
        }

        Console.WriteLine($"а) максимальная сумма: {max_sum}");
        Console.WriteLine($"б) минимальное произведение: {min_prod}");
    }
}