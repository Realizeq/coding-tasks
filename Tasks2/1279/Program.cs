using System;
class Program
{
    static void Main()
    {
        bool A = true;
        bool B = false;
        bool C = false;

        Console.WriteLine($"а) {A || B}");
        Console.WriteLine($"б) {A && B}");
        Console.WriteLine($"в) {B || C}");
    }
}