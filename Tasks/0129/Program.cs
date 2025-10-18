using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты первого прямоугольника:");
        Console.Write("x1: ");
        float x1_1 = float.Parse(Console.ReadLine());
        Console.Write("y1: ");
        float y1_1 = float.Parse(Console.ReadLine());
        Console.Write("x2: ");
        float x2_1 = float.Parse(Console.ReadLine());
        Console.Write("y2: ");
        float y2_1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Введите координаты прямоугольника:");
        Console.Write("x1: ");
        float x1_2 = float.Parse(Console.ReadLine());
        Console.Write("y1: ");
        float y1_2 = float.Parse(Console.ReadLine());
        Console.Write("x2: ");
        float x2_2 = float.Parse(Console.ReadLine());
        Console.Write("y2: ");
        float y2_2 = float.Parse(Console.ReadLine());

        float minX = Math.Min(x1_1, x1_2);
        float minY = Math.Min(y1_1, y1_2);
        float maxX = Math.Max(x2_1, x2_2);
        float maxY = Math.Max(y2_1, y2_2);

        Console.WriteLine($"Левый нижний угол: ({minX}, {minY})");
        Console.WriteLine($"Правый верхний угол: ({maxX}, {maxY})");
    }
}