using System;
class Program
{
    static void Main()
    {
        int countPos = 0;
        int countNeg = 0;

        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"a{i}: ");
            double a = double.Parse(Console.ReadLine());

            if (a > 0) countPos++;
            if (a < 0) countNeg++;
        }

        Console.WriteLine($"положительных: {countPos}");
        Console.WriteLine($"отрицательных: {countNeg}");
    }
}