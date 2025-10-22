using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int n = int.Parse(Console.ReadLine());

        float sum = 0;
        for (int i = n; i <= 2 * n; i++)
        {
            sum += 1.0f / (i * i);
        }

        Console.WriteLine($"{sum:f2}");
    }
}