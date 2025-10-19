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

        int count = 0;

        if (a < 0) count = count + 1;
        if (b < 0) count = count + 1;
        if (c < 0) count = count + 1;
        if (d < 0) count = count + 1;

        Console.WriteLine($"Количество отрицательных чисел: {count}");
    }
}