using System;
class program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты вершины А:");
        Console.Write("x: ");
        float x1 = Convert.ToSingle(Console.ReadLine());
        Console.Write("y: ");
        float y1 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Введите координаты вершины B:");
        Console.Write("x: ");
        float x2 = Convert.ToSingle(Console.ReadLine());
        Console.Write("y: ");
        float y2 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Введите координаты вершины C:");
        Console.Write("x: ");
        float x3 = Convert.ToSingle(Console.ReadLine());
        Console.Write("y: ");
        float y3 = Convert.ToSingle(Console.ReadLine());

        float AB = MathF.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        float BC = MathF.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
        float CA = MathF.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));

        float p = AB + BC + CA;

        float sP = p / 2f;
        float S = MathF.Sqrt(sP * (sP - AB) * (sP - BC) * (sP - CA));

        Console.WriteLine($"Периметр: {p:f2}");
        Console.WriteLine($"Площадь: {S:f2}");
    }
}