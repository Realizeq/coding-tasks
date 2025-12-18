using System;
class Program
{
    static int Sign(float a)
    {
        if (a > 0) return 1;
        if (a < 0) return -1;
        return 0;
    }

    static void Main()
    {
        Console.Write("Введите x: ");
        float x = float.Parse(Console.ReadLine());

        Console.Write("Введите y: ");
        float y = float.Parse(Console.ReadLine());

        int z = Sign(x) + Sign(y);

        Console.WriteLine($"z = {z}");
    }
}