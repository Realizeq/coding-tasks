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
            massiv2[i] = massiv1[i];
        }

        Console.Write("Прямой порядок: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(massiv2[i] + " ");
        }

        for (int i = 0; i < 10; i++)
        {
            massiv3[i] = massiv1[9 - i];
        }

        Console.WriteLine();
        Console.Write("Обратный порядок: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(massiv3[i] + " ");
        }
    }
}