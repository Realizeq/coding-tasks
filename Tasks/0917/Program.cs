using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 13, 17, 18, 40, 5, 7, 22, 11 };

        Console.WriteLine("Массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        int indexPary = -1;
        for (int i = 0; i < massiv.Length - 1; i++)
        {
            if (massiv[i] % 2 != 0 && massiv[i + 1] % 2 != 0)
            {
                indexPary = i;
                break;
            }
        }

        if (indexPary != -1)
        {
            Console.WriteLine($"Первая пара соседних нечетных: {indexPary} и {indexPary + 1}");
        }
        else
        {
            Console.WriteLine("Нет пар соседних нечетных чисел");
        }
    }
}