using System;
class Program
{
    static void Main()
    {
        float x;

        x = 20;
        x = -30;
        x = x + 5;
        Console.WriteLine($"а) {x}");

        x = 23.5f;
        x = -20;
        x = 0;
        Console.WriteLine($"б) {x}");

        x = 50;
        x = x * 2;
        x = -40;
        x = x + 10;
        Console.WriteLine($"в) {x}");
    }
}