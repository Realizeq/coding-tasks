using System;
class Program
{
    static void PrintTriangle(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void PrintDiamond(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.WriteLine("а)");
        PrintTriangle(10);

        Console.WriteLine("\nб)");
        PrintDiamond(6);
    }
}