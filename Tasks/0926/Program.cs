using System;
class Program
{
    static void Main()
    {
        int[] chislo1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        int[] chislo2 = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

        int[] summa = new int[21];
        int perenos = 0;

        for (int i = 19; i >= 0; i--)
        {
            int tempSum = chislo1[i] + chislo2[i] + perenos;
            summa[i + 1] = tempSum % 10;
            perenos = tempSum / 10;
        }
        summa[0] = perenos;

        Console.WriteLine("а) Сложение 20-значных чисел:");
        Console.Write("Число 1: ");
        for (int i = 0; i < 20; i++) Console.Write(chislo1[i]);
        Console.WriteLine();

        Console.Write("Число 2: ");
        for (int i = 0; i < 20; i++) Console.Write(chislo2[i]);
        Console.WriteLine();

        Console.Write("Сумма: ");
        for (int i = 0; i < 21; i++) Console.Write(summa[i]);
        Console.WriteLine();
        int[] chislo3 = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
        int[] chislo4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        int[] raznica = new int[30];
        int zaim = 0;

        for (int i = 29; i >= 0; i--)
        {
            int tempRazn = chislo3[i] - chislo4[i] - zaim;
            if (tempRazn < 0)
            {
                tempRazn += 10;
                zaim = 1;
            }
            else
            {
                zaim = 0;
            }
            raznica[i] = tempRazn;
        }

        Console.WriteLine("б) Вычитание 30-значных чисел:");
        Console.Write("Число 1: ");
        for (int i = 0; i < 30; i++) Console.Write(chislo3[i]);
        Console.WriteLine();

        Console.Write("Число 2: ");
        for (int i = 0; i < 30; i++) Console.Write(chislo4[i]);
        Console.WriteLine();

        Console.Write("Разность: ");
        for (int i = 0; i < 30; i++) Console.Write(raznica[i]);
        Console.WriteLine();
    }
}