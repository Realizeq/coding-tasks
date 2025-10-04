using System;
class program
{
    static void Main()
    {
        Console.WriteLine("Введите длины оснований:");
        Console.Write("a) ");
        float a = Convert.ToSingle(Console.ReadLine());
        Console.Write("b) ");
        float b = Convert.ToSingle(Console.ReadLine());
        Console.Write("Введите угол: ");
        float c = Convert.ToSingle(Console.ReadLine());

        float cR = c * MathF.PI / 180f;
        float h = (a - b) / 2f * MathF.Tan(cR);
        float S = (a + b) / 2f * h;

        Console.WriteLine($"Площадь: {S:f2}");
    }
}