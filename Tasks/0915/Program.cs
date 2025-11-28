using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 8, 30, 12, 35, 35, 18, 40, 5, 22 };

        Console.WriteLine("Массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        int indexPary = -1;
        for (int i = 0; i < massiv.Length - 1; i++)
        {
            if (massiv[i] == massiv[i + 1])
            {
                indexPary = i;
                break;
            }
        }

        if (indexPary != -1)
        {
            Console.WriteLine($"Первая пара одинаковых соседних: {indexPary} и {indexPary + 1}");
        }
        else
        {
            Console.WriteLine("Нет одинаковых соседних элементов");
        }
    }
}