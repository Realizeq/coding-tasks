using System;
class Program
{
    static void Main()
    {
        float sum = 0;
        for (int i = 2; i <= 10; i++)
        {
            sum += (float)i / (i + 1);
        }

        Console.WriteLine($"{sum:f2}");
    }
}