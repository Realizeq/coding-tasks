using System;
class Program
{
    static void Main()
    {
        bool X = true;
        bool Y = true;
        bool Z = false;

        Console.WriteLine($"а) {!X && Y}");
        Console.WriteLine($"б) {X || !Y}");
        Console.WriteLine($"в) {X || (Y && Z)}");
    }
}