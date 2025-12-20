using System;
class Program
{
    static void Main()
    {
        float s, k, d;

        s = 14;
        k = -3;
        d = s + 1;
        s = d;
        k = 2 * s;

        Console.WriteLine($"s = {s}, k = {k}");
    }
}