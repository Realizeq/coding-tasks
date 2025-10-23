using System;
class Program
{
    static void Main()
    {
        float sum = 0.0f;

        for (int i = 1; i <= 50; i++)
        {
            sum += (float)Math.Sqrt(i);
        }

        Console.WriteLine($"{sum:f4}");
    }
}