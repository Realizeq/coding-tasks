using System;
class Program
{
    static void Main()
    {
        float a = 40;
        float b = 10;
        b = -a / 2 * b;
        float c;

        if (a < b)
            c = b - a;
        else
            c = a - 2 * b;

        Console.WriteLine($"c = {c}");
    }
}