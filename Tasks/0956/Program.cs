using System;
class Program
{
    static void Main()
    {
        float[] p = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        float[] q = new float[12];

        for (int i = 0; i < 12; i++)
        {
            if (i >= 2 && i <= 9)
            {
                q[i] = -p[i];
            }
            else
            {
                q[i] = p[i] * i;
            }
        }

        Console.Write("Массив p: ");
        for (int i = 0; i < 12; i++)
        {
            Console.Write(p[i] + " ");
        }

        Console.WriteLine();
        Console.Write("Массив q: ");
        for (int i = 0; i < 12; i++)
        {
            Console.Write(q[i] + " ");
        }
    }
}