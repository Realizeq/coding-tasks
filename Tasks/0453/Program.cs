using System;
class Program
{
    static void Main()
    {
        double sum = 0;

        Console.Write("введите количество чисел: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"введите число a{i}: ");
            double a = double.Parse(Console.ReadLine());
            sum += a;
        }

        double srednee = sum / n;
        Console.WriteLine($"среднее арифметическое: {srednee}");
    }
}