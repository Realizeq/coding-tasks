using System;
class Program
{
    static void Main()
    {
        float R = 6350.0f;

        Console.WriteLine("Высота  Расстояние");

        for (int h = 1; h <= 10; h++)
        {
            float distance = (float)Math.Sqrt(h * (2 * R + h));
            Console.WriteLine($"{h,-7} {distance,-11:F2}");
        }
    }
}