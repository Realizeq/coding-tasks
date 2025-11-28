using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15000, 25000, 80000, 30000, 12000, 35000, 18000, 40000, 50000, 22000, 70000, 17000, 30000 };

        Console.WriteLine("Массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        int indexFirst = -1;
        int i1 = 0;
        while (i1 < massiv.Length && indexFirst == -1)
        {
            if (massiv[i1] > 65530)
            {
                indexFirst = i1;
            }
            i1++;
        }

        int indexLast = -1;
        int i2 = massiv.Length - 1;
        while (i2 >= 0 && indexLast == -1)
        {
            if (massiv[i2] > 65530)
            {
                indexLast = i2;
            }
            i2--;
        }

        Console.WriteLine($"а) Первый >65530: {indexFirst}");
        Console.WriteLine($"б) Последний >65530: {indexLast}");
    }
}