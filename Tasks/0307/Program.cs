using System;
class Program
{
    static void Main()
    {
        float totalVolume = 0.0f;
        float diameter = 10.0f;

        for (int i = 1; i <= 12; i++)
        {
            float externalDiameter = diameter + 1.0f;

            float radius = externalDiameter / 2.0f;
            float volume = (4.0f / 3.0f) * (float)Math.PI * radius * radius * radius;

            totalVolume += volume;

            diameter = externalDiameter;
        }

        float totalLiters = totalVolume / 1000.0f;

        Console.WriteLine($"{totalLiters:F2}");
    }
}