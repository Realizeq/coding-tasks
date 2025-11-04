using System;
class Program
{
    static void Main()
    {
        int sum1 = 0;
        int sum2 = 0;

        for (int i = 1; i <= 14; i++)
        {
            Console.Write($"b{i}: ");
            int b = int.Parse(Console.ReadLine());

            if (b > 20) sum1 += b;
            if (b < 50) sum2 += b;
        }

        if (sum1 > 100) Console.WriteLine("а) да");
        else Console.WriteLine("а) нет");

        if (sum2 % 2 == 0) Console.WriteLine("б) да");
        else Console.WriteLine("б) нет");
    }
}