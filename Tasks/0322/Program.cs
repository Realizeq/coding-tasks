using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n (1 < n < 10): ");
        int n = int.Parse(Console.ReadLine());

        int totalSum = 0;
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            totalSum += factorial;
        }

        Console.WriteLine($"{totalSum}");
    }
}