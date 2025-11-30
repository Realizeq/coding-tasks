using System;
class Program
{
    static void Main()
    {
        float[] m = { 2, -3, 4, -5, 6, -7, 8, -9, 10, -11 };
        float[] n = new float[10];

        for (int i = 0; i < 10; i++)
        {
            if (m[i] >= 0)
            {
                n[i] = m[i] / 3;
            }
            else
            {
                n[i] = m[i] * m[i];
            }
        }

        Console.Write("Массив m: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(m[i] + " ");
        }

        Console.WriteLine();
        Console.Write("Массив n: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(n[i] + " ");
        }
    }
}