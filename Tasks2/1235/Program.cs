using System;
class Program
{
    static float Ploshad(float a, float b, float c)
    {
        float p = (a + b + c) / 2;
        return (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    static void Main()
    {
        Console.Write("Введите a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Введите c: ");
        float c = float.Parse(Console.ReadLine());
        Console.Write("Введите d: ");
        float d = float.Parse(Console.ReadLine());
        Console.Write("Введите e: ");
        float e = float.Parse(Console.ReadLine());

        float s1 = Ploshad(a, b, e);
        float s2 = Ploshad(e, c, d);

        float summa = s1 + s2;

        Console.WriteLine($"Площадь пятиугольника = {summa}");
    }
}