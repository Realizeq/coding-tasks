using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22 };

        int max1 = massiv[0];
        int max2 = int.MinValue;

        for (int i = 1; i < massiv.Length; i++)
        {
            if (massiv[i] > max1)
            {
                max2 = max1;
                max1 = massiv[i];
            }
            else if (massiv[i] > max2 && massiv[i] != max1)
            {
                max2 = massiv[i];
            }
        }

        Console.WriteLine($"Максимальный: {max1}");
        Console.WriteLine($"Второй максимальный: {max2}");

        int min1 = massiv[0];
        int min2 = int.MaxValue;

        for (int i = 1; i < massiv.Length; i++)
        {
            if (massiv[i] < min1)
            {
                min2 = min1;
                min1 = massiv[i];
            }
            else if (massiv[i] < min2 && massiv[i] != min1)
            {
                min2 = massiv[i];
            }
        }

        Console.WriteLine($"Минимальный: {min1}");
        Console.WriteLine($"Второй минимальный: {min2}");

        int indexMax1 = 0;
        int indexMax2 = -1;

        for (int i = 1; i < massiv.Length; i++)
        {
            if (massiv[i] > massiv[indexMax1])
            {
                indexMax2 = indexMax1;
                indexMax1 = i;
            }
            else if (indexMax2 == -1 || massiv[i] > massiv[indexMax2])
            {
                if (massiv[i] != massiv[indexMax1])
                {
                    indexMax2 = i;
                }
            }
        }

        Console.WriteLine($"Номер максимального: {indexMax1}");
        Console.WriteLine($"Номер второго максимального: {indexMax2}");

        int indexMin1 = 0;
        int indexMin2 = -1;

        for (int i = 1; i < massiv.Length; i++)
        {
            if (massiv[i] < massiv[indexMin1])
            {
                indexMin2 = indexMin1;
                indexMin1 = i;
            }
            else if (indexMin2 == -1 || massiv[i] < massiv[indexMin2])
            {
                if (massiv[i] != massiv[indexMin1])
                {
                    indexMin2 = i;
                }
            }
        }

        Console.WriteLine($"Номер минимального: {indexMin1}");
        Console.WriteLine($"Номер второго минимального: {indexMin2}");
    }
}