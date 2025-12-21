using System;
class Program
{
    static void Main()
    {
        bool A = false;
        bool B = false;
        bool C = true;

        Console.WriteLine($"а) {(!A || !B) && !C}");
        Console.WriteLine($"б) {(!A || !B) && (A || B)}");
        Console.WriteLine($"в) {(A && B) || (A && C) || !C}");
    }
}