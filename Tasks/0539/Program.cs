using System;
class Program
{
    static void Main()
    {
        double sum_boy = 0;
        double sum_girl = 0;
        int count_boy = 0;
        int count_girl = 0;

        Console.Write("количество учеников: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"ученик {i}: ");
            double rost = double.Parse(Console.ReadLine());

            if (rost < 0)
            {
                sum_boy += Math.Abs(rost);
                count_boy++;
            }
            else
            {
                sum_girl += rost;
                count_girl++;
            }
        }

        if (count_boy > 0)
        {
            double average_boy = sum_boy / count_boy;
            Console.WriteLine($"средний рост мальчиков: {average_boy}");
        }

        if (count_girl > 0)
        {
            double average_girl = sum_girl / count_girl;
            Console.WriteLine($"средний рост девочек: {average_girl}");
        }
    }
}