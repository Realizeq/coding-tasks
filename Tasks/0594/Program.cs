using System;
class Program
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        int max_value = int.MinValue;
        int min_value = int.MaxValue;
        int max_index = 0;
        int min_index = 0;

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"x{j}: ");
            int x = int.Parse(Console.ReadLine());

            if (x > max_value)
            {
                max_value = x;
                max_index = j;
            }

            if (x < min_value)
            {
                min_value = x;
                min_index = j;
            }
        }

        if (max_index < min_index) Console.WriteLine("максимальное");
        else if (min_index < max_index) Console.WriteLine("минимальное");
        else Console.WriteLine("одновременно");
    }
}