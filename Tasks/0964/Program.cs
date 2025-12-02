using System;
class Program
{
    static void Main()
    {
        float[] massiv1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        float[] massiv2 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        float[] summ = new float[10];
        float[] proizv = new float[10];
        float[] max = new float[10];

        for (int i = 0; i < 10; i++)
        {
            summ[i] = massiv1[i] + massiv2[i];
            proizv[i] = massiv1[i] * massiv2[i];

            if (massiv1[i] > massiv2[i])
            {
                max[i] = massiv1[i];
            }
            else
            {
                max[i] = massiv2[i];
            }
        }

        Console.Write("Сумма: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(summ[i] + " ");
        }

        Console.WriteLine();
        Console.Write("Произведение: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(proizv[i] + " ");
        }

        Console.WriteLine();
        Console.Write("Максимум: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(max[i] + " ");
        }
    }
}