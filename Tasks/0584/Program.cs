using System;
class Program
{
    static void Main()
    {
        int max_value = int.MinValue;
        int max_index = 0;
        int min_value = int.MaxValue;
        int min_index = 0;

        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"a{j}: ");
            int a = int.Parse(Console.ReadLine());

            if (a >= max_value)
            {
                max_value = a;
                max_index = j;
            }

            if (a < min_value)
            {
                min_value = a;
                min_index = j;
            }
        }

        Console.WriteLine($"а) номер последнего максимального: {max_index}");
        Console.WriteLine($"б) номер первого минимального: {min_index}");
    }
}