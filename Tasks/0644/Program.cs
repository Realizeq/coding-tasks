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

        Console.WriteLine("День с максимальным доходом для каждого магазина:");

        int max1 = magazin1[0];
        int denMax1 = 1;
        for (int i = 1; i < 10; i++)
        {
            if (magazin1[i] > max1)
            {
                max1 = magazin1[i];
                denMax1 = i + 1;
            }
        }
        Console.WriteLine($"Магазин 1: {denMax1} числа");

        int max2 = magazin2[0];
        int denMax2 = 1;
        for (int i = 1; i < 10; i++)
        {
            if (magazin2[i] > max2)
            {
                max2 = magazin2[i];
                denMax2 = i + 1;
            }
        }
        Console.WriteLine($"Магазин 2: {denMax2} числа");

        int max3 = magazin3[0];
        int denMax3 = 1;
        for (int i = 1; i < 10; i++)
        {
            if (magazin3[i] > max3)
            {
                max3 = magazin3[i];
                denMax3 = i + 1;
            }
        }
        Console.WriteLine($"Магазин 3: {denMax3} числа");

        Console.WriteLine("Магазин с максимальным доходом для каждого дня:");
        for (int i = 0; i < 10; i++)
        {
            int maxDen = magazin1[i];
            int magazinMax = 1;

            if (magazin2[i] > maxDen)
            {
                maxDen = magazin2[i];
                magazinMax = 2;
            }
            if (magazin3[i] > maxDen)
            {
                maxDen = magazin3[i];
                magazinMax = 3;
            }

            Console.WriteLine($"День {i + 1}: магазин {magazinMax}");
        }
    }
}