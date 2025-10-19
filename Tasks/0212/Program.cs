using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        float x = float.Parse(Console.ReadLine());

        float abs = x;
        if (x < 0) abs = -x;

        Console.WriteLine($"Абсолютная величина: {abs}");
    }
}