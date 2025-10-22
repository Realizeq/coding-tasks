using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        float sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += (float)Math.Sqrt(2 * i);
        }

        Console.WriteLine($"{sum:f2}");
    }
}