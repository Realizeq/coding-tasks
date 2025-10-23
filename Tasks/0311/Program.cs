using System;
class Program
{
    static void Main()
    {
        int n = 1000;
        float width = (float)Math.PI / n;
        float area = 0.0f;

        for (int i = 0; i < n; i++)
        {
            float x = i * width;
            float height = (float)Math.Sin(x);
            area += height * width;
        }

        Console.WriteLine($"{area:f2}");
    }
}