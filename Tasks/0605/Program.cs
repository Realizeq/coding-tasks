using System;
class Program
{
    static void Main()
    {
        int max = int.MinValue;
        int min = int.MaxValue;
        int count_max = 0;
        int count_min = 0;

        for (int j = 1; j <= 12; j++)
        {
            Console.Write($"s{j}: ");
            int s = int.Parse(Console.ReadLine());

            if (s > max)
            {
                max = s;
                count_max = 1;
            }
            else if (s == max)
            {
                count_max++;
            }

            if (s < min)
            {
                min = s;
                count_min = 1;
            }
            else if (s == min)
            {
                count_min++;
            }
        }

        Console.WriteLine($"а) максимально раз встречается: {count_max}");
        Console.WriteLine($"б) минимально раз встречается: {count_min}");
    }
}