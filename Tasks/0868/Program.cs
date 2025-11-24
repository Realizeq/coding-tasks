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

        Console.WriteLine("а) Удален максимальный элемент:");
        int maxIndex = 0;
        for (int i = 1; i < massiv.Length; i++)
        {
            if (massiv[i] > massiv[maxIndex])
            {
                maxIndex = i;
            }
        }
        for (int i = maxIndex; i < massiv.Length - 1; i++)
        {
            massiv[i] = massiv[i + 1];
        }
        massiv[massiv.Length - 1] = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("б) Удален минимальный элемент:");
        int minIndex = 0;
        for (int i = 1; i < massiv.Length; i++)
        {
            if (massiv[i] < massiv[minIndex])
            {
                minIndex = i;
            }
        }
        for (int i = minIndex; i < massiv.Length - 1; i++)
        {
            massiv[i] = massiv[i + 1];
        }
        massiv[massiv.Length - 1] = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }
    }
}