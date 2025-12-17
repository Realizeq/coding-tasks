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

    static void Main()
    {
        Console.Write("Введите количество символов: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите символ: ");
        char c = Console.ReadLine()[0];

        Simvoly(n, c);
    }
}