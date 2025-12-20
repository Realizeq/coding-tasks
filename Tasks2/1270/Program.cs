using System;
class Program
{
    static void Main()
    {
        float p, q, d;

        p = 0;
        q = 30;
        d = q - 5;
        q = 2 * d;
        p = q - 100;

        Console.WriteLine($"p = {p}, q = {q}");
    }
}