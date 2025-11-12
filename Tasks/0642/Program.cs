using System;
class Program
{
    static void Main()
    {
        int[] magazin1 = new int[10];
        int[] magazin2 = new int[10];
        int[] magazin3 = new int[10];

        for (int den = 0; den < 10; den++)
        {
            Console.WriteLine($"День {den + 1}:");
            Console.Write("Магазин 1: ");
            magazin1[den] = int.Parse(Console.ReadLine());
            Console.Write("Магазин 2: ");
            magazin2[den] = int.Parse(Console.ReadLine());
            Console.Write("Магазин 3: ");
            magazin3[den] = int.Parse(Console.ReadLine());
        }

        int summa1 = 0;
        int summa2 = 0;
        int summa3 = 0;

        for (int i = 0; i < 10; i++)
        {
            summa1 += magazin1[i];
            summa2 += magazin2[i];
            summa3 += magazin3[i];
        }

        int maxSumma = summa1;
        int magazinMax = 1;
        if (summa2 > maxSumma)
        {
            maxSumma = summa2;
            magazinMax = 2;
        }
        if (summa3 > maxSumma)
        {
            maxSumma = summa3;
            magazinMax = 3;
        }
        Console.WriteLine($"Максимальный общий доход у магазина {magazinMax}: {maxSumma}");

        int maxObshiiDohod = 0;
        int denMax = 1;
        for (int i = 0; i < 10; i++)
        {
            int obshiiDohod = magazin1[i] + magazin2[i] + magazin3[i];
            if (obshiiDohod > maxObshiiDohod)
            {
                maxObshiiDohod = obshiiDohod;
                denMax = i + 1;
            }
        }
        Console.WriteLine($"Максимальный общий доход фирмы был {denMax} числа: {maxObshiiDohod}");

        int maxDohodZaDen = magazin1[0];
        int magazinMaxDen = 1;
        int denMaxDohod = 1;

        for (int i = 0; i < 10; i++)
        {
            if (magazin1[i] > maxDohodZaDen)
            {
                maxDohodZaDen = magazin1[i];
                magazinMaxDen = 1;
                denMaxDohod = i + 1;
            }
            if (magazin2[i] > maxDohodZaDen)
            {
                maxDohodZaDen = magazin2[i];
                magazinMaxDen = 2;
                denMaxDohod = i + 1;
            }
            if (magazin3[i] > maxDohodZaDen)
            {
                maxDohodZaDen = magazin3[i];
                magazinMaxDen = 3;
                denMaxDohod = i + 1;
            }
        }
        Console.WriteLine($"Максимальный доход за день: магазин {magazinMaxDen} {denMaxDohod} числа: {maxDohodZaDen}");
    }
}