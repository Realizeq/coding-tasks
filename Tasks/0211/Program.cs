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

        Console.Write("Введите четвертое число: ");
        float d = float.Parse(Console.ReadLine());

        float max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        if (d > max) max = d;
        Console.WriteLine($"а) Наибольшее число: {max}");

        float min = a;
        if (b < min) min = b;
        if (c < min) min = c;
        if (d < min) min = d;
        Console.WriteLine($"б) Наименьшее число: {min}");
    }
}