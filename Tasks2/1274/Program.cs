using System;
class Program
{
    static void Main()
    {
        float a = 56;
        float b = 77;

        if (a > b)
            a = a - b;
        else
            b = b - a;

        Console.WriteLine($"a = {a}");
    }
}