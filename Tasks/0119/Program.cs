using System;
class Program
{
    static void Main()
    {
        float kmh, ms;

        Console.Write("Введите скорость в км/ч: ");
        kmh = float.Parse(Console.ReadLine());

        Console.Write("Введите скорость в м/с: ");
        ms = float.Parse(Console.ReadLine());

        float kmhToMs = kmh / 3.6f;

        string result;

        if (kmhToMs > ms)
        {
            result = "км/ч";
        }
        else
        {
            result = "м/с";
        }

        Console.WriteLine($"Большая скорость: {result}");
    }
}