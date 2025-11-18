using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 12, 5, 8, 3, 15, 10, 7, 2, 9, 1 };

        int summa = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            summa += massiv[i];
        }

        if (summa % 2 == 0)
        {
            Console.WriteLine("Верно, сумма четная");
        }
        else
        {
            Console.WriteLine("Неверно, сумма нечетная");
        }

        int summaKvadratov = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            summaKvadratov += massiv[i] * massiv[i];
        }

        if (summaKvadratov >= 10000 && summaKvadratov <= 99999)
        {
            Console.WriteLine("Верно, сумма квадратов пятизначная");
        }
        else
        {
            Console.WriteLine("Неверно, сумма квадратов не пятизначная");
        }
    }
}