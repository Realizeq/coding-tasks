using System;
class Program
{
    static void Main()
    {
        bool A = true;
        bool B = false;
        bool C = false;

        Console.WriteLine($"а) {A || !(A && B) || C}");
        Console.WriteLine($"б) {!A || (A && (B || C))}");
        Console.WriteLine($"в) {(A || (B && !C)) && C}");
    }
}