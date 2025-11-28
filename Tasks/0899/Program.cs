using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 5, 35, 18, 40, 5, 22, 5, 17, 30 };

        Console.WriteLine("Массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        int indexFirst = -1;
        int i1 = 0;
        while (i1 < massiv.Length && indexFirst == -1)
        {
            if (massiv[i1] == 5)
            {
                indexFirst = i1;
            }
            i1++;
        }

        int indexLast = -1;
        int i2 = massiv.Length - 1;
        while (i2 >= 0 && indexLast == -1)
        {
            if (massiv[i2] == 5)
            {
                indexLast = i2;
            }
            i2--;
        }

        Console.WriteLine($"а) Первая пятерка: {indexFirst}");
        Console.WriteLine($"б) Последняя пятерка: {indexLast}");
    }
}