using System;
class Program
{
    static void Main()
    {
        double sum = 0;
        int count = 0;

        Console.Write("m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= m; i++)
        {
            Console.Write($"b{i}: ");
            int b = int.Parse(Console.ReadLine());

            if (b % n == 0)
            {
                sum += b;
                count++;
            }
        }

        double average = sum / count;
        Console.WriteLine($"среднее арифметическое: {average}");
    }
}