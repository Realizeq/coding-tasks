using System;
class Program
{
    static void Main()
    {
        int max_len = 1;
        int current_len = 1;

        Console.Write("количество чисел: ");
        int n = int.Parse(Console.ReadLine());

        int prev = int.Parse(Console.ReadLine());

        for (int j = 2; j <= n; j++)
        {
            int current = int.Parse(Console.ReadLine());

            if (current > prev)
            {
                current_len++;
                if (current_len > max_len) max_len = current_len;
            }
            else
            {
                current_len = 1;
            }

            prev = current;
        }

        Console.WriteLine($"наибольшая длина возрастающего фрагмента: {max_len}");
    }
}