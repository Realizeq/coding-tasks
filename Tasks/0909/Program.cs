using System;
class Program
{
    static void Main()
    {
        double[] massiv = { 15.5, -24.2, 8.7, -30.1, 12.8, 35.9, -18.6, 40.3, -5.4, 22.7 };

        Console.WriteLine("Массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        int indexFirstOtr = -1;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] < 0)
            {
                indexFirstOtr = i;
                break;
            }
        }

        if (indexFirstOtr != -1)
        {
            Console.WriteLine($"а) Первый отрицательный: {indexFirstOtr}");
            Console.WriteLine("Элементы после него:");
            for (int i = indexFirstOtr + 1; i < massiv.Length; i++)
            {
                Console.WriteLine($"{massiv[i]}");
            }
        }
        else
        {
            Console.WriteLine("а) Отрицательных чисел нет");
        }

        int indexLastOtr = -1;
        for (int i = massiv.Length - 1; i >= 0; i--)
        {
            if (massiv[i] < 0)
            {
                indexLastOtr = i;
                break;
            }
        }

        if (indexLastOtr != -1)
        {
            Console.WriteLine($"б) Последний отрицательный: {indexLastOtr}");
            Console.WriteLine("Элементы до него:");
            for (int i = 0; i < indexLastOtr; i++)
            {
                Console.WriteLine($"{massiv[i]}");
            }
        }
        else
        {
            Console.WriteLine("б) Отрицательных чисел нет");
        }
    }
}