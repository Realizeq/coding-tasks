using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        int cube = 0;
        int first = n * (n - 1) + 1;

        for (int i = 0; i < n; i++)
        {
            cube += first + 2 * i;
        }

        Console.WriteLine($"{n}^3 = {cube}");
    }
}