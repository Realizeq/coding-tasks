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
        Console.Write("Введите высоту: ");
        float h = Convert.ToSingle(Console.ReadLine());

        float bDiff = (a - b) / 2f;
        float side = MathF.Sqrt(h * h + bDiff * bDiff);
        float p = a + b + 2 * side;

        Console.WriteLine($"Периметр: {p:f2}");
    }
}