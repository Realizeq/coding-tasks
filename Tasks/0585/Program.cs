using System;
class Program
{
    static void Main()
    {
        int max_value = int.MinValue;
        int max_index = 0;
        int min_value = int.MaxValue;
        int min_index = 0;

        Console.Write("m: ");
        int m = int.Parse(Console.ReadLine());

        for (int j = 1; j <= m; j++)
        {
            Console.Write($"d{j}: ");
            int d = int.Parse(Console.ReadLine());

            if (d >= max_value)
            {
                max_value = d;
                max_index = j;
            }

            if (d <= min_value)
            {
                min_value = d;
                min_index = j;
            }
        }

        Console.WriteLine($"номер последнего максимального: {max_index}");
        Console.WriteLine($"номер последнего минимального: {min_index}");
    }
}