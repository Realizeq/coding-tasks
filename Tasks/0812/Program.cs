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

        double srednee = (double)summa / massiv.Length;

        int blizhayshii = massiv[0];
        double minRaznica = Math.Abs(massiv[0] - srednee);

        for (int i = 1; i < massiv.Length; i++)
        {
            double raznica = Math.Abs(massiv[i] - srednee);
            if (raznica < minRaznica)
            {
                minRaznica = raznica;
                blizhayshii = massiv[i];
            }
        }

        Console.WriteLine($"Среднее значение: {srednee}");
        Console.WriteLine($"Наиболее близкий элемент: {blizhayshii}");
    }
}