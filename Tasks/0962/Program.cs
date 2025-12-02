using System;
class Program
{
    static void Main()
    {
        int[] massiv1 = { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10 };
        int[] massiv2 = new int[10];
        int[] massiv3 = new int[10];
        int[] massiv4 = new int[10];
        int[] massiv5 = new int[10];

        for (int i = 0; i < 10; i++)
        {
            if (massiv1[i] > 0)
            {
                massiv2[i] = massiv1[i];
            }
            else
            {
                massiv3[i] = massiv1[i];
            }
        }

        Console.Write("Положительные на тех же местах: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(massiv2[i] + " ");
        }

        Console.WriteLine();
        Console.Write("Остальные на тех же местах: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(massiv3[i] + " ");
        }

        int index1 = 0;
        int index2 = 0;

        for (int i = 0; i < 10; i++)
        {
            if (massiv1[i] > 0)
            {
                massiv4[index1] = massiv1[i];
                index1++;
            }
            else
            {
                massiv5[index2] = massiv1[i];
                index2++;
            }
        }

        Console.WriteLine();
        Console.Write("Положительные подряд: ");
        for (int i = 0; i < index1; i++)
        {
            Console.Write(massiv4[i] + " ");
        }

        Console.WriteLine();
        Console.Write("Остальные подряд: ");
        for (int i = 0; i < index2; i++)
        {
            Console.Write(massiv5[i] + " ");
        }
    }
}