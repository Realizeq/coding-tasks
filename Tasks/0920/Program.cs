using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22, 50, 45, 60 };

        Console.WriteLine("Массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        int indexTroiki = -1;
        for (int i = 1; i < massiv.Length - 1; i++)
        {
            if (massiv[i] > massiv[i - 1] && massiv[i] > massiv[i + 1])
            {
                indexTroiki = i - 1;
                break;
            }
        }

        if (indexTroiki != -1)
        {
            Console.WriteLine($"Первая тройка: {indexTroiki}, {indexTroiki + 1}, {indexTroiki + 2}");
        }
        else
        {
            Console.WriteLine("Нет троек где средний больше соседей");
        }
    }
}