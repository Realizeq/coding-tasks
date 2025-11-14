using System;
class Program
{
    static void Main()
    {
        for (int x = 1; x <= 30; x++)
        {
            for (int y = x; y <= 30; y++)
            {
                for (int k = 1; k <= 30; k++)
                {
                    if (x * x + y * y == k * k)
                    {
                        Console.WriteLine($"{x}^2 + {y}^2 = {k}^2");
                    }
                }
            }
        }
    }
}