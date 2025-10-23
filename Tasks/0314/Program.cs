using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"{factorial}");
    }
}