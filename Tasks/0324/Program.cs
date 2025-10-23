using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите x: ");
        float x = float.Parse(Console.ReadLine());
        Console.Write("Введите n (1 < n < 10): ");
        int n = int.Parse(Console.ReadLine());

        float sum = 1.0f;
        float power = 1.0f;
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            power *= x;
            factorial *= i;
            sum += power / factorial;
        }

        Console.WriteLine($"{sum:f2}");
    }
}