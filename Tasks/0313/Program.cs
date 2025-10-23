using System;
class Program
{
    static void Main()
    {
        int n = 1000;
        float width = 4.0f / n;
        float area = 0.0f;

        for (int i = 0; i < n; i++)
        {
            float x = -4.0f + i * width;
            float y = 0.4f * (x + 2) * (x + 2) + 1;
            area += y * width;
        }

        Console.WriteLine($"{area:f4}");
    }
}