using System;
class Program
{
    static void Main()
    {
        float a = 100;
        float b = 30;
        a = a - b * 3;
        float c;

        if (a > b)
            c = a - b;
        else
            c = b - a;

        Console.WriteLine($"c = {c}");
    }
}