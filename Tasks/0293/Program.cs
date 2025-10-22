using System;
class Program
{
    static void Main()
    {
        float x = 2.0f;
        float sum = 0;
        float factorial = 1;

        for (int i = 1; i <= 10; i++)
        {
            factorial *= i;
            sum += (float)Math.Pow(x, i) / factorial;
        }

        Console.WriteLine($"{sum:f2}");
    }
}