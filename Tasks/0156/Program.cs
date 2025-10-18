using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число x: ");
        float x = float.Parse(Console.ReadLine());

        float f;

        if (x >= 0.2f && x <= 0.9f)
        {
            f = (float)Math.Sin(x);
        }
        else
        {
            f = 1;
        }

        Console.WriteLine($"f({x}) = {f}");
    }
}