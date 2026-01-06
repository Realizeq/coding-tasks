using System;

class Program
{
    static void Main()
    {
        for (int x = 1; x <= 30; x++)
        {
            for (int y = x; y <= 30; y++)
            {
                int k2 = x * x + y * y;
                int k = (int)Math.Sqrt(k2);
                if (k <= 30 && k * k == k2)
                {
                    Console.WriteLine($"x={x}, y={y}, k={k}");
                }
            }
        }
    }
}