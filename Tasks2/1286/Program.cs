using System;
class Program
{
    static void Main()
    {
        bool X = false;
        bool Y = true;
        bool Z = false;

        Console.WriteLine($"а) {(X && !(Z || Y)) || !Z}");
        Console.WriteLine($"б) {!X || (X && (Y || Z))}");
        Console.WriteLine($"в) {(X || (Y && !Z)) && Z}");
    }
}