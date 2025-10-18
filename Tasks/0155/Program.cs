using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число x: ");
        float x = float.Parse(Console.ReadLine());

        float f;

        if (x >= -2.4f && x <= 5.7f)
        {
            f = x * x;
        }
        else
        {
            f = 4;
        }

        Console.WriteLine($"f({x}) = {f}");
    }
}