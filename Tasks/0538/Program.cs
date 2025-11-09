using System;
class Program
{
    static void Main()
    {
        double sum_full = 0;
        double sum_other = 0;
        int count_full = 0;
        int count_other = 0;

        Console.Write("количество людей: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"человек {i}: ");
            double massa = double.Parse(Console.ReadLine());

            if (massa > 100)
            {
                sum_full += massa;
                count_full++;
            }
            else
            {
                sum_other += massa;
                count_other++;
            }
        }

        double average_full = sum_full / count_full;
        double average_other = sum_other / count_other;

        Console.WriteLine($"средняя масса полных: {average_full}");
        Console.WriteLine($"средняя масса остальных: {average_other}");
    }
}