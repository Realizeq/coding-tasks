using System;
class Program
{
    static void Main()
    {
        float[] massiv1 = { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10 };
        float[] massiv2 = { 2, -3, 4, -5, 6, -7, 8, -9, 10, -11 };
        int[] result = new int[10];

        for (int i = 0; i < 10; i++)
        {
            if (massiv1[i] > 0 && massiv2[i] > 0)
            {
                result[i] = 1;
            }
            else if (massiv1[i] < 0 && massiv2[i] < 0)
            {
                result[i] = 1;
            }
            else
            {
                result[i] = 0;
            }
        }

        Console.Write("Массив 1: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(massiv1[i] + " ");
        }

        Console.WriteLine();
        Console.Write("Массив 2: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(massiv2[i] + " ");
        }

        Console.WriteLine();
        Console.Write("Результат: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(result[i] + " ");
        }
    }
}