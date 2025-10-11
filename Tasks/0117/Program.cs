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

        float max = a > b ? a : b;
        float min = a < b ? a : b;

        Console.WriteLine($"Максимальное: {max}");
        Console.WriteLine($"Минимальное: {min}");
    }
}