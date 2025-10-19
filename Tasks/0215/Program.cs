using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        float b = float.Parse(Console.ReadLine());

        if (Math.Sqrt(b) < a)
        {
            b = b * 5;
        }

        Console.WriteLine($"{b}");
    }
}