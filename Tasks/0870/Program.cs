using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, -25, 8, -30, 12, 35, -18, 40, -5, 22 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("а) Удален первый отрицательный элемент:");
        int indexOtr = -1;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] < 0)
            {
                indexOtr = i;
                break;
            }
        }
        if (indexOtr != -1)
        {
            for (int i = indexOtr; i < massiv.Length - 1; i++)
            {
                massiv[i] = massiv[i + 1];
            }
            massiv[massiv.Length - 1] = 0;
        }
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("б) Удален последний четный элемент:");
        int indexChet = -1;
        for (int i = massiv.Length - 1; i >= 0; i--)
        {
            if (massiv[i] % 2 == 0)
            {
                indexChet = i;
                break;
            }
        }
        if (indexChet != -1)
        {
            for (int i = indexChet; i < massiv.Length - 1; i++)
            {
                massiv[i] = massiv[i + 1];
            }
            massiv[massiv.Length - 1] = 0;
        }
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }
    }
}