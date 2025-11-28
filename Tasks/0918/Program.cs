using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 24, 8, 30, 12, 36, 18, 40, 5, 22, 44, 11 };

        Console.WriteLine("Массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        int indexPary = -1;
        for (int i = 0; i < massiv.Length - 1; i++)
        {
            if (massiv[i] % 2 == 0 && massiv[i + 1] % 2 == 0)
            {
                indexPary = i;
            }
        }

        if (indexPary != -1)
        {
            Console.WriteLine("Элементы до последней пары четных:");
            for (int i = 0; i < indexPary; i++)
            {
                Console.WriteLine($"{massiv[i]}");
            }
        }
        else
        {
            Console.WriteLine("Нет пар соседних четных чисел");
        }
    }
}