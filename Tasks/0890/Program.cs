using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        int poslednii = massiv[massiv.Length - 1];
        for (int i = massiv.Length - 1; i > 0; i--)
        {
            massiv[i] = massiv[i - 1];
        }
        massiv[0] = poslednii;

        Console.WriteLine("После перестановки:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }
    }
}