using System;
class Program
{
    static void Main()
    {
        int[] massiv1 = { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10 };
        int[] massiv2 = new int[10];

        int left = 0;
        int right = 9;

        for (int i = 0; i < 10; i++)
        {
            if (massiv1[i] < 0)
            {
                massiv2[left] = massiv1[i];
                left++;
            }
            else
            {
                massiv2[right] = massiv1[i];
                right--;
            }
        }

        Console.Write("Исходный массив: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(massiv1[i] + " ");
        }

        Console.WriteLine();
        Console.Write("Новый массив: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(massiv2[i] + " ");
        }
    }
}