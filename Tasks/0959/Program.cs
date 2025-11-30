using System;
class Program
{
    static void Main()
    {
        int[] massiv1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] massiv2 = new int[10];
        int[] massiv3 = new int[10];

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 1)
            {
                massiv2[i] = massiv1[i];
            }
        }

        Console.Write("На тех же местах: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(massiv2[i] + " ");
        }

        int index = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 1)
            {
                massiv3[index] = massiv1[i];
                index++;
            }
        }

        Console.WriteLine();
        Console.Write("Подряд с начала: ");
        for (int i = 0; i < index; i++)
        {
            Console.Write(massiv3[i] + " ");
        }
    }
}