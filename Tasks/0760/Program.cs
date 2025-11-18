using System;
class Program
{
    static void Main()
    {
        int[] osadki = { 5, 0, 3, 7, 2, 0, 4, 1, 6, 0, 8, 3, 0, 2, 5, 0, 1, 4, 7, 0, 3, 6, 2, 0, 5, 1, 0, 4, 2, 3 };

        int pervayaDecada = 0;
        int vtorayaDecada = 0;
        int tretiyaDecada = 0;

        for (int i = 0; i < 10; i++)
        {
            pervayaDecada += osadki[i];
        }

        for (int i = 10; i < 20; i++)
        {
            vtorayaDecada += osadki[i];
        }

        for (int i = 20; i < 30; i++)
        {
            tretiyaDecada += osadki[i];
        }

        double sredneePervaya = (double)pervayaDecada / 10;
        double sredneeVtoraya = (double)vtorayaDecada / 10;
        double sredneeTretiya = (double)tretiyaDecada / 10;

        Console.WriteLine($"Среднее за первую декаду: {sredneePervaya}");
        Console.WriteLine($"Среднее за вторую декаду: {sredneeVtoraya}");
        Console.WriteLine($"Среднее за третью декаду: {sredneeTretiya}");
    }
}