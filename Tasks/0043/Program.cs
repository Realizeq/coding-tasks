using System;
class program
{
    static void Main()
    {
        // Первая точка
        Console.WriteLine("Введите коорд. первой точки: ");
        float x1 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Введите коорд. первой точки: ");
        float y1 = Convert.ToSingle(Console.ReadLine());

        // Вторая точка
        Console.WriteLine("Введите коорд. второй точки: ");
        float x2 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Введите коорд. второй точки: ");
        float y2 = Convert.ToSingle(Console.ReadLine());

        float diffX = x2 - x1;
        float diffY = y2 - y1;
        float dist = MathF.Sqrt(diffX * diffX + diffY * diffY);

        Console.WriteLine($"Расстояние: {dist:f2}");
    }
}