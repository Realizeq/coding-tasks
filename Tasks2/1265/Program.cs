using System;
class Program
{
    static void Main()
    {
        float a, b, c;

        a = 5;
        a = a + 6;
        b = -a;
        c = a - 2 * b;

        Console.WriteLine($"c = {c}");
    }
}