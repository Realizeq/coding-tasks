using System;
class Program
{
    static void Main()
    {
        double sum = 0;

        Console.Write("m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("p: ");
        double p = double.Parse(Console.ReadLine());

        for (int i = 1; i <= m; i++)
        {
            Console.Write($"b{i}: ");
            double b = double.Parse(Console.ReadLine());
            if (b > p)
            {
                sum += b;
            }
        }

        Console.WriteLine($"сумма чисел больше {p}: {sum}");
    }
}