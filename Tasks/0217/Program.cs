using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Введите третье число: ");
        float c = float.Parse(Console.ReadLine());

        if (a >= 0)
        {
            a = a * a;
        }

        if (b >= 0)
        {
            b = b * b;
        }

        if (c >= 0)
        {
            c = c * c;
        }

        Console.WriteLine($"В квадрате: {a}, {b}, {c}");
    }
}