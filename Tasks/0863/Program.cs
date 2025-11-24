using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        for (int i = 0; i < 3; i++)
        {
            int temp = massiv[i];
            massiv[i] = massiv[massiv.Length - 3 + i];
            massiv[massiv.Length - 3 + i] = temp;
        }

        Console.WriteLine("После перестановки:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }
    }
}