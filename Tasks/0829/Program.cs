using System;
class Program
{
    static void Main()
    {
        int[] ocenki = { 8, 9, 7, 8, 9, 6, 8, 9 };

        int max = ocenki[0];
        int min = ocenki[0];
        int summa = 0;

        for (int i = 0; i < ocenki.Length; i++)
        {
            summa += ocenki[i];
            if (ocenki[i] > max)
            {
                max = ocenki[i];
            }
            if (ocenki[i] < min)
            {
                min = ocenki[i];
            }
        }

        summa = summa - max - min;
        double srednee = (double)summa / (ocenki.Length - 2);

        Console.WriteLine($"Оценка в зачет: {srednee}");
    }
}