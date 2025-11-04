using System;
class Program
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        int sum1 = 0;
        int sum2 = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"m{i}: ");
            int m = int.Parse(Console.ReadLine());

            if (m < 25.5) sum1 += m;
            if (m <= 20) sum2 += m;
        }

        if (sum1 <= 50) Console.WriteLine("а) да");
        else Console.WriteLine("а) нет");

        if (sum2 % 3 == 0) Console.WriteLine("б) да");
        else Console.WriteLine("б) нет");
    }
}