using System;
class Program
{
    static void Main()
    {
        float sum = 0;
        float factorial = 1;

        for (int i = 1; i <= 10; i++)
        {
            factorial *= i;
            sum += 1.0f / factorial;
        }

        Console.WriteLine($"{sum:f2}");
    }
}