using System;
class Program
{
    static void Main()
    {
        float[] m = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        float[] n = new float[10];

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 1)
            {
                n[i] = i * m[i];
            }
            else
            {
                n[i] = m[i] / i;
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