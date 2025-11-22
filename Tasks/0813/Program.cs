using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22, 28, 17, 33, 11, 26, 19, 37, 9, 24, 31 };

        int maxSumma = 0;
        int maxIndex = 0;

        for (int i = 0; i <= massiv.Length - 5; i++)
        {
            int summa = 0;
            for (int j = i; j < i + 5; j++)
            {
                summa += massiv[j];
            }

            if (summa > maxSumma)
            {
                maxSumma = summa;
                maxIndex = i;
            }
        }

        Console.WriteLine($"Максимальная сумма 5 соседних элементов: {maxSumma}");
        Console.WriteLine("Элементы:");
        for (int i = maxIndex; i < maxIndex + 5; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }
    }
}