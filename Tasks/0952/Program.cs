using System;
class Program
{
    static void Main()
    {
        float[] x = { 2.5f, 1.2f, 3.7f, 0.8f, 4.2f, 1.8f, 3.1f, 0.5f, 4.5f, 1.1f, 3.9f, 0.7f, 4.1f, 1.5f, 3.3f, 0.9f, 4.3f, 1.3f, 3.5f, 0.6f };
        float[] y = { 1.8f, 0.5f, 2.7f, 0.3f, 3.1f, 1.2f, 2.3f, 0.2f, 3.4f, 0.9f, 2.9f, 0.4f, 3.2f, 1.1f, 2.5f, 0.7f, 3.3f, 1.0f, 2.7f, 0.3f };

        float minX = float.MaxValue;
        float maxX = float.MinValue;
        float minY = float.MaxValue;
        float maxY = float.MinValue;

        for (int i = 0; i < 20; i++)
        {
            if (x[i] < minX) minX = x[i];
            if (x[i] > maxX) maxX = x[i];
            if (y[i] < minY) minY = y[i];
            if (y[i] > maxY) maxY = y[i];
        }

        Console.WriteLine($"Левый нижний угол: ({minX}, {minY})");
        Console.WriteLine($"Правый верхний угол: ({maxX}, {maxY})");
    }
}