using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 0, 8, 30, 0, 35, 18, 0, 5, 22, 0, 17, 30 };

        Console.WriteLine("Массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        int indexFirst = -1;
        int i1 = 0;
        while (i1 < massiv.Length && indexFirst == -1)
        {
            if (massiv[i1] == 0)
            {
                indexFirst = i1;
            }
            i1++;
        }

        Console.WriteLine("а) Все элементы кроме первого нуля:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (i != indexFirst)
            {
                Console.WriteLine($"{massiv[i]}");
            }
        }

        int indexLast = -1;
        int i2 = massiv.Length - 1;
        while (i2 >= 0 && indexLast == -1)
        {
            if (massiv[i2] == 0)
            {
                indexLast = i2;
            }
            i2--;
        }

        Console.WriteLine("б) Все элементы кроме последнего нуля:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (i != indexLast)
            {
                Console.WriteLine($"{massiv[i]}");
            }
        }
    }
}