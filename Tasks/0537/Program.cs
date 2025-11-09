using System;
class Program
{
    static void Main()
    {
        double sum_even = 0;
        double sum_odd = 0;
        int count_even = 0;
        int count_odd = 0;

        for (int i = 1; i <= 12; i++)
        {
            Console.Write($"число {i}: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                sum_even += num;
                count_even++;
            }
            else
            {
                sum_odd += num;
                count_odd++;
            }
        }

        if (count_even > 0)
        {
            double average_even = sum_even / count_even;
            Console.WriteLine($"среднее четных: {average_even}");
        }

        if (count_odd > 0)
        {
            double average_odd = sum_odd / count_odd;
            Console.WriteLine($"среднее нечетных: {average_odd}");
        }
    }
}