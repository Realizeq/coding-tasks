using System;
class Program
{
    static void Main()
    {
        float a, b;

        a = 3.4f;
        b = -5.1f;
        a = a;
        b = a;
        Console.WriteLine($"а) a = {a}, b = {b}");

        a = 9.4f;
        b = 15.1f;
        a = b;
        b = a;
        Console.WriteLine($"б) a = {a}, b = {b}");
    }
}