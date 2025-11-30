using System;
class Program
{
    static void Main()
    {
        float[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        float[] b = new float[10];

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                b[i] = a[i] * a[i];
            }
            else
            {
                b[i] = 2 * a[i];
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