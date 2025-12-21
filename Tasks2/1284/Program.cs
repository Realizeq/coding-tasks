using System;
class Program
{
    static void Main()
    {
        bool X = false;
        bool Y = false;
        bool Z = true;

        Console.WriteLine($"а) {X || (Y && !Z)}");
        Console.WriteLine($"б) {!X && !Y}");
        Console.WriteLine($"в) {!(X && Z) || Y}");
        Console.WriteLine($"г) {X && !Y || Z}");
        Console.WriteLine($"д) {X && (!Y || Z)}");
        Console.WriteLine($"е) {X || !(Y || Z)}");
    }
}