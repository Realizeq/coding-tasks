using System;
class Program
{
    static void Main()
    {
        float s, k, d;

        s = 13;
        k = -5;
        d = s + 2;
        s = d;
        k = 2 * s;
        Console.WriteLine($"а) s = {s}, k = {k}");

        s = 0;
        k = 15;
        d = k - 2;
        k = 3 * d;
        s = k - 50;
        Console.WriteLine($"б) s = {s}, k = {k}");
    }
}