using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n (n > 2): ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= n - 1; i++)
        {
            sum += i * (i + 1);
        }

        Console.WriteLine($"{sum}");
    }
}