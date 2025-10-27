using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а) ");
        for (int i = 10; i <= 99; i++)
        {
            int d1 = i / 10;
            int d2 = i % 10;
            int sumSquares = d1 * d1 + d2 * d2;
            if (sumSquares % 13 == 0)
            {
                Console.Write($"{i} ");
            }
        }

        Console.WriteLine();

        Console.WriteLine("б) ");
        for (int i = 10; i <= 99; i++)
        {
            int sum = i / 10 + i % 10;
            if (i == sum + sum * sum)
            {
                Console.Write($"{i} ");
            }
        }
    }
}