using System;
class Program
{
    static void Main()
    {
        for (float x = 0.1f; x <= 1.5f; x += 0.1f)
        {
            float sinValue = (float)Math.Sin(x);
            Console.WriteLine($"sin {x:F1} = {sinValue:F2}");
        }
    }
}