using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а):");
        for (int i = 10; i <= 25; i++)
        {
            Console.WriteLine($"{i} {i}.4");
        }

        Console.WriteLine("\nб):");
        for (int i = 25; i <= 35; i++)
        {
            Console.WriteLine($"{i} {i}.5 {i - 0.2}");
        }
    }
}