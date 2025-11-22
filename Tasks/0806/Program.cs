using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22 };

        int min = massiv[0];
        int max = massiv[0];

        for (int i = 1; i < massiv.Length; i++)
        {
            if (massiv[i] < min)
            {
                min = massiv[i];
            }
            if (massiv[i] > max)
            {
                max = massiv[i];
            }
        }

        double sredneeMinMax = (min + max) / 2.0;

        int count = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] > sredneeMinMax)
            {
                count++;
                Console.WriteLine($"Элемент {i}: {massiv[i]}");
            }
        }

        Console.WriteLine($"Элементов больше среднего min и max: {count}");
    }
}