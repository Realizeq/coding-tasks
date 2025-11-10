using System;
class Program
{
    static void Main()
    {
        int max = int.MinValue;
        int min = int.MaxValue;

        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"a{j}: ");
            int a = int.Parse(Console.ReadLine());

            if (a > max) max = a;
            if (a < min) min = a;
        }

        if (max - min <= 25) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}