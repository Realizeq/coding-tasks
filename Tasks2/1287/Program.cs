using System;
class Program
{
    static void Main()
    {
        bool X = true;
        bool Y = false;
        bool Z = false;

        Console.WriteLine($"а) {!X || !Y || !Z}");
        Console.WriteLine($"б) {(!X || !Y) && (X || Y)}");
        Console.WriteLine($"в) {(X && Y) || (X && Z) || !Z}");
    }
}