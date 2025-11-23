using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22, 40, 17, 30, 11, 40 };

        int max = massiv[0];
        int min = massiv[0];

        Console.WriteLine("а) Номера минимальных элементов:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] < min)
            {
                min = massiv[i];
            }
        }
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] == min)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("б) Номера максимальных элементов:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] > max)
            {
                max = massiv[i];
            }
        }
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] == max)
            {
                Console.WriteLine(i);
            }
        }
    }
}