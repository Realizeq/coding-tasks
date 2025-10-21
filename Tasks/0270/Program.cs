using System;
class Program
{
    static void Main()
    {
        for (int i = 2; i <= 15; i++)
        {
            float sinValue = (float)Math.Sin(i);
            Console.WriteLine($"sin {i} = {sinValue:F4}");
        }
    }
}