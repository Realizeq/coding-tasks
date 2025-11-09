using System;
class Program
{
    static void Main()
    {
        double sum = 0;
        int count = 0;

        for (int i = 1; i <= 16; i++)
        {
            Console.Write($"c{i}: ");
            double c = double.Parse(Console.ReadLine());

            if (c > 20)
            {
                sum += c;
                count++;
            }
        }

        double average = sum / count;
        Console.WriteLine($"среднее арифметическое: {average}");
    }
}