using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 12, 8, 15, 24, 30, 7, 18, 42, 9, 20 };

        int count = 0;
        for (int i = 0; i < massiv.Length - 1; i++)
        {
            if (massiv[i] % 2 == 0 && massiv[i + 1] % 2 == 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Пар соседних четных элементов: {count}");
    }
}