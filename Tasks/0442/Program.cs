using System;
class Program
{
    static void Main()
    {
        Console.Write("введите натуральное число n: ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"введите число a{i}: ");
            double a = double.Parse(Console.ReadLine());
            sum += a * a;
        }

        Console.WriteLine($"сумма квадратов: {sum}");
    }
}