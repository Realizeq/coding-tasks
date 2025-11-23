using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22, 40, 17, 30, 11, 40 };

        int max = massiv[0];
        int min = massiv[0];
        int countMax = 1;
        int countMin = 1;

        for (int i = 1; i < massiv.Length; i++)
        {
            if (massiv[i] > max)
            {
                max = massiv[i];
                countMax = 1;
            }
            else if (massiv[i] == max)
            {
                countMax++;
            }

            if (massiv[i] < min)
            {
                min = massiv[i];
                countMin = 1;
            }
            else if (massiv[i] == min)
            {
                countMin++;
            }
        }

        Console.WriteLine($"Максимальных элементов: {countMax}");
        Console.WriteLine($"Минимальных элементов: {countMin}");
    }
}