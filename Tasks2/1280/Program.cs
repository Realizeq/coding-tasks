using System;
class Program
{
    static void Main()
    {
        bool X = false;
        bool Y = true;
        bool Z = false;

        Console.WriteLine($"а) {X || Z}");
        Console.WriteLine($"б) {X && Y}");
        Console.WriteLine($"в) {X && Z}");
    }
}