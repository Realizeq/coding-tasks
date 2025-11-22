using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22 };

        int summa = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            summa += massiv[i];
        }

        int count = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] > summa)
            {
                count++;
                Console.WriteLine($"Элемент {i}: {massiv[i]}");
            }
        }

        Console.WriteLine($"Элементов больше суммы всех: {count}");
    }
}