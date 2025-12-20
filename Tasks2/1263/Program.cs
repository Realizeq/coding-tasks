using System;
class Program
{
    static void Main()
    {
        float s;

        s = 25;
        s = 55;
        Console.WriteLine($"а) {s}");

        s = 5;
        s = -2 * s;
        s = 0;
        Console.WriteLine($"б) {s}");

        s = -3.5f;
        s = 4 * s;
        Console.WriteLine($"в) {s}");

        s = 20;
        s = -21;
        s = 5 * s;
        Console.WriteLine($"г) {s}");
    }
}