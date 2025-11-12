using System;
class Program
{
    static void Main()
    {
        float m = 10.0f;

        Console.WriteLine($"m = {m}");
        Console.WriteLine("Числа последовательности меньше m:");

        for (int x = 1; x <= 100; x++)
        {
            float y = (x * x + 100.0f) / (x + 200.0f);

            if (y < m)
            {
                Console.WriteLine($"x = {x}, y = {y}");
            }
        }

        int x2 = 1;
        while (x2 <= 100)
        {
            float y = (x2 * x2 + 100.0f) / (x2 + 200.0f);

            if (y < m)
            {
                Console.WriteLine($"x = {x2}, y = {y}");
            }
            x2++;
        }
    }
}