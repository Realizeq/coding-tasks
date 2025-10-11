using System;

class Program
{
    static void Main()
    {
        float x, y;

        Console.Write("Введите координату x: ");
        x = float.Parse(Console.ReadLine());

        Console.Write("Введите координату y: ");
        y = float.Parse(Console.ReadLine());

        string region;

        if (x > 0)
        {
            region = "I";
        }
        else
        {
            region = "II";
        }

        Console.WriteLine($"Точка находится в области: {region}");
    }
}