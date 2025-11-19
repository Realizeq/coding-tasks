using System;
class Program
{
    static void Main()
    {
        int[] osadki = { 5, 0, 3, 7, 2, 0, 4, 1, 6, 0, 8, 3, 0, 2, 5, 0, 1, 4, 7, 0, 3, 6, 2, 0, 5, 1, 0, 4, 2, 3, 0 };

        int summa = 0;
        int count = 0;

        for (int i = 0; i < osadki.Length; i++)
        {
            if (osadki[i] > 0)
            {
                summa += osadki[i];
                count++;
            }
        }

        if (count > 0)
        {
            double srednee = (double)summa / count;
            Console.WriteLine($"Среднее количество осадков в дождливые дни: {srednee}");
        }
        else
        {
            Console.WriteLine("Не было дождливых дней");
        }
    }
}