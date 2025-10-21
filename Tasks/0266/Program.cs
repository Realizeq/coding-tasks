using System;
class Program
{
    static void Main()
    {
        float p0 = 1.29f;
        float a = 1.25e-4f;

        Console.WriteLine("Высота  Плотность");

        for (int h = 0; h <= 1000; h += 100)
        {
            float p = p0 * (float)Math.Exp(-a * h);
            Console.WriteLine($"{h,-7} {p,-10:F4}");
        }
    }
}