using System;
class Program
{
    static void Main()
    {
        float a, b;

        Console.Write("Введите первое число: ");
        a = float.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        b = float.Parse(Console.ReadLine());

        float max = (a + b + Math.Abs(a - b)) / 2;
        float min = (a + b - Math.Abs(a - b)) / 2;

        Console.WriteLine($"а) Большее число: {max}");
        Console.WriteLine($"б) Меньшее число: {min}");
    }
}