using System;
class Program
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        int max1 = int.MinValue;
        int max2 = int.MinValue;
        int min1 = int.MaxValue;
        int min2 = int.MaxValue;

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"x{j}: ");
            int x = int.Parse(Console.ReadLine());

            // двух максимальных
            if (x > max1)
            {
                max2 = max1;
                max1 = x;
            }
            else if (x > max2)
            {
                max2 = x;
            }

            // двух минимальных
            if (x < min1)
            {
                min2 = min1;
                min1 = x;
            }
            else if (x < min2)
            {
                min2 = x;
            }
        }

        Console.WriteLine($"а) два максимальных: {max1} и {max2}");
        Console.WriteLine($"б) два минимальных: {min1} и {min2}");
    }
}