using System;
class Program
{
    static void Main()
    {
        float a = 32;
        float b = -1;
        b = a - b * 4;
        float c;

        if (a > b)
            c = 6 * b - 4 * a;
        else
            c = a - b;

        Console.WriteLine($"c = {c}");
    }
}