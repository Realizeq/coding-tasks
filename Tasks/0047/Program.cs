using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты вершины A:");
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

        Console.WriteLine("Введите координаты вершины D:");
        Console.Write("x: ");
        float x4 = Convert.ToSingle(Console.ReadLine());
        Console.Write("y: ");
        float y4 = Convert.ToSingle(Console.ReadLine());

        float S1 = MathF.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2f);

        float S2 = MathF.Abs((x1 * (y3 - y4) + x3 * (y4 - y1) + x4 * (y1 - y3)) / 2f);

        float sumS = S1 + S2;

        Console.WriteLine($"Сумма площадей: {sumS:f2}");
    }
}