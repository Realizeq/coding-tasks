using System;
class Program
{
    static void Main()
    {
        int max_len = 0;
        int current_len = 0;

        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"d{j}: ");
            int d = int.Parse(Console.ReadLine());

            if (d % 2 == 0)
            {
                current_len++;
                if (current_len > max_len) max_len = current_len;
            }
            else
            {
                current_len = 0;
            }
        }

        Console.WriteLine($"наибольшая длина отрезка: {max_len}");
    }
}