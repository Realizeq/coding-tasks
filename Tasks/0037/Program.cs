using System;
class program
{
    static void Main()
    {
        // Ввод значений e f g h
        Console.WriteLine("Введите значение e: ");
        float e = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Введите значение f: ");
        float f = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Введите значение g: ");
        float g = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Введите значение h: ");
        float h = Convert.ToSingle(Console.ReadLine());

        // Вычисление функций
        float sqrtV = MathF.Sqrt(e - 3f / f);
        float a = MathF.Pow(sqrtV, 3f) + g;

        float cosH = MathF.Cos(h);
        float b = MathF.Sin(e) + cosH * cosH;

        float c = (33f * g) / (e * f - 3f);

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"c = {c}");
    }
}