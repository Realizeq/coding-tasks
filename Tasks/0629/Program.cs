using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а)");
        for (int j = 1; j <= 9; j++)
        {
            for (int i = 1; i <= 9; i++)
            {
                Console.Write($"{i} + {j} = {i + j} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("б)");
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                Console.Write($"{i} + {j} = {i + j} ");
            }
            Console.WriteLine();
        }
    }
}