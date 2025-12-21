using System;
class Program
{
    static void Main()
    {
        bool A = true;
        bool B = false;
        bool C = false;

        Console.WriteLine($"а) {A || (B && !C)}");
        Console.WriteLine($"б) {!A && !B}");
        Console.WriteLine($"в) {!(A && C) || B}");
        Console.WriteLine($"г) {A && !B || C}");
        Console.WriteLine($"д) {A && (!B || C)}");
        Console.WriteLine($"е) {A || !(B && C)}");
    }
}