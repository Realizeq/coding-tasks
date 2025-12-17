using System;
class Program
{
    static void Simvoly(int kolichestvo, char simvol)
    {
        for (int i = 0; i < kolichestvo; i++)
        {
            Console.Write(simvol);
        }
        Console.WriteLine();
    }

    static void PrintRectangle1(int shirina, int vysota)
    {
        for (int i = 0; i < vysota; i++)
        {
            for (int j = 0; j < shirina; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void PrintRectangle2(int shirina, int vysota)
    {
        for (int i = 0; i < vysota; i++)
        {
            Simvoly(shirina, '*');
        }
    }

    static void Main()
    {
        Console.Write("Введите ширину прямоугольника: ");
        int shirina = int.Parse(Console.ReadLine());

        Console.Write("Введите высоту прямоугольника: ");
        int vysota = int.Parse(Console.ReadLine());

        Console.WriteLine("\nСпособ 1 (без функции):");
        PrintRectangle1(shirina, vysota);

        Console.WriteLine("\nСпособ 2 (с функцией):");
        PrintRectangle2(shirina, vysota);
    }
}