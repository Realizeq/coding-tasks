using System;
class Program
{
    static void PrintFrame()
    {
        // Верхняя граница
        for (int i = 0; i < 60; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();

        // Боковые границы
        for (int i = 0; i < 18; i++)
        {
            Console.Write("*");
            for (int j = 0; j < 58; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("*");
        }

        // Нижняя граница
        for (int i = 0; i < 60; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        PrintFrame();
    }
}