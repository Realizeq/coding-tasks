using System;
class Program
{
    static void Main()
    {
        int max_count = 1;
        int current_count = 1;

        Console.Write("количество чисел: ");
        int n = int.Parse(Console.ReadLine());

        int prev = int.Parse(Console.ReadLine());

        for (int j = 2; j <= n; j++)
        {
            int current = int.Parse(Console.ReadLine());

            if (current == prev)
            {
                current_count++;
                if (current_count > max_count) max_count = current_count;
            }
            else
            {
                current_count = 1;
            }

            prev = current;
        }

        Console.WriteLine($"наибольшее количество подряд: {max_count}");
    }
}