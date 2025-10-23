using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n (1 < n < 10): ");
        int n = int.Parse(Console.ReadLine());

        float sum = 0.0f;
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            sum += 1.0f / factorial;
        }

        Console.WriteLine($"{sum:f2}");
    }
}