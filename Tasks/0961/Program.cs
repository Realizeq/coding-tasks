using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        int[] chetniy = new int[10];
        int[] nechetniy = new int[10];

        int index1 = 0;
        int index2 = 0;

        for (int i = 0; i < 20; i++)
        {
            if (i % 2 == 0)
            {
                chetniy[index1] = massiv[i];
                index1++;
            }
            else
            {
                nechetniy[index2] = massiv[i];
                index2++;
            }
        }

        Console.Write("Элементы с четными индексами: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(chetniy[i] + " ");
        }

        Console.WriteLine();
        Console.Write("Элементы с нечетными индексами: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(nechetniy[i] + " ");
        }
    }
}