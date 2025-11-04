using System;
class Program
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        double sum_abs = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"a{i}: ");
            double a = double.Parse(Console.ReadLine());
            sum_abs += Math.Abs(a);
        }
        Console.WriteLine($"а) {sum_abs}");

        double prod_abs = 1;
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"a{i}: ");
            double a = double.Parse(Console.ReadLine());
            prod_abs *= Math.Abs(a);
        }
        Console.WriteLine($"б) {prod_abs}");

        double[] arr = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"a{i + 1}: ");
            arr[i] = double.Parse(Console.ReadLine());
        }

        Console.Write("в) ");
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write($"{arr[i] + arr[i + 1]} ");
        }
        Console.WriteLine();

        double sum_alt = 0;
        int sign = 1;
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"a{i}: ");
            double a = double.Parse(Console.ReadLine());
            sum_alt += sign * a;
            sign = -sign;
        }
        Console.WriteLine($"г) {sum_alt}");
    }
}