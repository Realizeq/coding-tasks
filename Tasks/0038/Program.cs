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
        float a = (e + f) / 3f;

        float b = MathF.Abs(h * h - g);

        float sqrtC = (g - h) * (g - h) - 3f * MathF.Sin(e);
        float c = MathF.Sqrt(sqrtC);

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"c = {c}");
    }
}