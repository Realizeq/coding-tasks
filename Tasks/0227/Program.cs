using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите x: ");
        float x = float.Parse(Console.ReadLine());

        float f;

        if (x <= 0)
        {
            f = 0;
        }
        else if (x <= 1)
        {
            f = x;
        }
        else
        {
            f = x * x;
        }

        Console.WriteLine($"f = {f}");
    }
}