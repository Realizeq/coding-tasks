using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а):");
        for (int i = 21; i <= 35; i++)
        {
            Console.WriteLine($"{i} {i - 0.6}");
        }

        Console.WriteLine("\nб):");
        for (int i = 16; i <= 24; i++)
        {
            Console.WriteLine($"{i} {i - 0.5} {i + 0.8}");
        }
    }
}