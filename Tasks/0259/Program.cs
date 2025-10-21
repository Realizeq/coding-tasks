using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а):");
        for (int i = 21; i >= 10; i--)
        {
            Console.WriteLine($"{i} {i - 1.8}");
        }

        Console.WriteLine("\nб):");
        for (int i = 45; i >= 25; i--)
        {
            Console.WriteLine($"{i} {i - 0.5} {i - 0.8}");
        }
    }
}