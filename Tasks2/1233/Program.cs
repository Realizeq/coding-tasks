using System;
class Program
{
    static float Perimetr(float a, float b, float h)
    {
        float katet = (Math.Abs(a - b)) / 2;
        float bok = (float)Math.Sqrt(katet * katet + h * h);
        return a + b + 2 * bok;
    }

    static void Main()
    {
        Console.Write("Введите a1: ");
        float a1 = float.Parse(Console.ReadLine());
        Console.Write("Введите b1: ");
        float b1 = float.Parse(Console.ReadLine());
        Console.Write("Введите h1: ");
        float h1 = float.Parse(Console.ReadLine());

        Console.Write("Введите a2: ");
        float a2 = float.Parse(Console.ReadLine());
        Console.Write("Введите b2: ");
        float b2 = float.Parse(Console.ReadLine());
        Console.Write("Введите h2: ");
        float h2 = float.Parse(Console.ReadLine());

        float p1 = Perimetr(a1, b1, h1);
        float p2 = Perimetr(a2, b2, h2);
        float summa = p1 + p2;

        Console.WriteLine($"Сумма периметров = {summa}");
    }
}