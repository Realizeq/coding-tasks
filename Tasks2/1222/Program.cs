using System;
class Program
{
    static void RisovatLiniyu()
    {
        for (int i = 0; i < 60; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

    static void PrintRectangle1()
    {
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 60; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void PrintRectangle2()
    {
        for (int i = 0; i < 20; i++)
        {
            RisovatLiniyu();
        }
    }

    static void Main()
    {
        Console.WriteLine("Способ 1 (без функции):");
        PrintRectangle1();

        Console.WriteLine("\nСпособ 2 (с функцией):");
        PrintRectangle2();
    }
}