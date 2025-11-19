using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 12, 8, 15, 24, 30, 7, 18, 42, 9, 20 };

        int count = 0;
        for (int i = 1; i < massiv.Length - 1; i++)
        {
            if (massiv[i] > massiv[i - 1] && massiv[i] > massiv[i + 1])
            {
                count++;
            }
        }

        Console.WriteLine($"Элементов больше соседей: {count}");
    }
}