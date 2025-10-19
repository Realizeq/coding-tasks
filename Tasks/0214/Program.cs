using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        float b = float.Parse(Console.ReadLine());

        float absA = a;
        if (a < 0) absA = -a;

        float absB = b;
        if (b < 0) absB = -b;

        if (absA > absB)
        {
            a = a / 2;
        }

        Console.WriteLine($"{a}");
    }
}