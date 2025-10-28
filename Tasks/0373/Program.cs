using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а) ");
        for (int i = 13; i < 100; i += 13)
        {
            Console.Write($"{i} ");
        }

        Console.WriteLine();

        Console.WriteLine("б) ");
        int j = 13;
        while (j < 100)
        {
            Console.Write($"{j} ");
            j += 13;
        }
    }
}