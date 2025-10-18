using System;
class Program
{
    static void Main()
    {
        float a, b, c;

        Console.Write("Введите a: ");
        a = float.Parse(Console.ReadLine());

        Console.Write("Введите b: ");
        b = float.Parse(Console.ReadLine());

        Console.Write("Введите c: ");
        c = float.Parse(Console.ReadLine());

        float d = b * b - 4 * a * c;

        if (d > 0)
        {
            float x1 = (-b + (float)Math.Sqrt(d)) / (2 * a);
            float x2 = (-b - (float)Math.Sqrt(d)) / (2 * a);
            Console.WriteLine($"Корни: x1 = {x1:f2}, x2 = {x2:f2}");
        }
        else
        {
            Console.WriteLine("Уравнение не имеет корней");
        }
    }
}