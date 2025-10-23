using System;
class Program
{
    static void Main()
    {
        int n = 1000;
        float width = 2.0f / n;
        float area = 0.0f;

        for (int i = 0; i < n; i++)
        {
            float x = 1.0f + i * width;
            float y = 0.3f * (x - 1) * (x - 1) + 3;
            if (y >= 2 && y <= 4)
            {
                area += (y - 2) * width;
            }
        }

        Console.WriteLine($"{area:f4}");
    }
}