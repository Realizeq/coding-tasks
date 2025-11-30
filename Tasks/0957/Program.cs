using System;
class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] b = new int[10];

        for (int i = 0; i < 10; i++)
        {
            if (a[i] % 2 == 0)
            {
                b[i] = a[i] * 2;
            }
            else
            {
                b[i] = a[i];
            }
        }

        Console.Write("Массив a: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(a[i] + " ");
        }

        Console.WriteLine();
        Console.Write("Массив b: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(b[i] + " ");
        }
    }
}