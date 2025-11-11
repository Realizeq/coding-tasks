using System;
class Program
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        int prev = int.Parse(Console.ReadLine());
        int current = int.Parse(Console.ReadLine());

        int max_sum = prev + current;
        int min_sum = prev + current;
        int max_index = 1;
        int min_index = 1;

        for (int j = 3; j <= n; j++)
        {
            int next = int.Parse(Console.ReadLine());
            int sum = current + next;

            // а) максимальная сумма
            if (sum > max_sum)
            {
                max_sum = sum;
                max_index = j - 1;
            }

            // б) минимальная сумма
            if (sum < min_sum)
            {
                min_sum = sum;
                min_index = j - 1;
            }
            else if (sum == min_sum)
            {
                min_index = j - 1;
            }

            current = next;
        }

        Console.WriteLine($"а) максимальная сумма: {max_sum}");
        Console.WriteLine($"б) минимальная сумма: {min_sum}");
        Console.WriteLine($"в) номера первой пары с максимальной суммой: {max_index} и {max_index + 1}");
        Console.WriteLine($"г) номера последней пары с минимальной суммой: {min_index} и {min_index + 1}");
    }
}