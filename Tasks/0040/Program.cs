using System;
class program
{
    static void Main()
    {
        Console.WriteLine("Введите длину a: ");
        float a = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Введите длину b: ");
        float b = Convert.ToSingle(Console.ReadLine());

        float per = 2 * (a + b);
        float di = MathF.Sqrt(a * a + b * b);

        Console.WriteLine($"Периметр: {per:f2}");
        Console.WriteLine($"Диагональ: {di:f2}");
    }
}