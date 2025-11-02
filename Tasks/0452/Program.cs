using System;
class Program
{
    static void Main()
    {
        Console.Write("введите натуральное число n: ");
        int n = int.Parse(Console.ReadLine());

        double proizvedenie = 1;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"введите число a{i}: ");
            double a = double.Parse(Console.ReadLine());
            proizvedenie *= a;
        }

        if (proizvedenie > 5) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}