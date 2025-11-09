using System;
class Program
{
    static void Main()
    {
        double sum = 0;
        int count = 0;

        for (int i = 1; i <= 14; i++)
        {
            Console.Write($"d{i}: ");
            int d = int.Parse(Console.ReadLine());

            if (d % 2 == 0)
            {
                sum += d;
                count++;
            }
        }

        if (count > 0)
        {
            double average = sum / count;
            Console.WriteLine($"среднее арифметическое: {average}");
        }
        else
        {
            Console.WriteLine("четных чисел нет");
        }
    }
}