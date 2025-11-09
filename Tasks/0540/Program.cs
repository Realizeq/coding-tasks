using System;
class Program
{
    static void Main()
    {
        double sum = 0;
        int count = 0;

        for (int i = 1; i <= 15; i++)
        {
            Console.Write($"b{i}: ");
            double b = double.Parse(Console.ReadLine());

            if (b > 10)
            {
                sum += b;
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
            Console.WriteLine("чисел больше 10 нет");
        }
    }
}