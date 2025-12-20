using System;
class Program
{
    static void Main()
    {
        float a, b, v;

        a = 40;
        b = 10;
        b = -a / 2 * b;
        v = b + a * 2;

        Console.WriteLine($"v = {v}");
    }
}