using System;
class Program
{
    static void Main()
    {
        int[] temperatura = { 25, 28, 30, 32, 29, 27, 26, 31, 33, 34, 30, 28, 29, 32, 35, 33, 31, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20, 19, 18, 17 };

        int maxSumma = 0;
        int maxIndex = 0;

        for (int i = 0; i <= temperatura.Length - 7; i++)
        {
            int summa = 0;
            for (int j = i; j < i + 7; j++)
            {
                summa += temperatura[j];
            }

            if (summa > maxSumma)
            {
                maxSumma = summa;
                maxIndex = i;
            }
        }

        Console.WriteLine("Самые теплые 7 дней:");
        for (int i = maxIndex; i < maxIndex + 7; i++)
        {
            Console.WriteLine($"{i + 1} июля: {temperatura[i]}°C");
        }
    }
}