using System;
class Program
{
    static void Main()
    {
        float r1, u1, r2, u2;

        Console.Write("Введите сопротивление первого участка: ");
        r1 = float.Parse(Console.ReadLine());

        Console.Write("Введите напряжение первого участка: ");
        u1 = float.Parse(Console.ReadLine());

        Console.Write("Введите сопротивление второго участка: ");
        r2 = float.Parse(Console.ReadLine());

        Console.Write("Введите напряжение второго участка: ");
        u2 = float.Parse(Console.ReadLine());

        float i1 = u1 / r1;
        float i2 = u2 / r2;

        string result;

        if (i1 < i2)
        {
            result = "первом";
        }
        else
        {
            result = "втором";
        }

        Console.WriteLine($"Меньший ток протекает на {result} участке");
    }
}