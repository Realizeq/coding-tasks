using System;
class Program
{
    static void Main()
    {
        int[] ocenki = { 5, 4, 3, 2, 5, 4, 3, 2, 5, 4, 3, 2, 5, 4, 3, 2, 5, 4, 3, 2, 5, 4 };

        int summa = 0;
        for (int i = 0; i < ocenki.Length; i++)
        {
            summa += ocenki[i];
        }

        double srednee = (double)summa / ocenki.Length;

        int count = 0;
        for (int i = 0; i < ocenki.Length; i++)
        {
            if (ocenki[i] < srednee)
            {
                count++;
                Console.WriteLine($"Ученик {i + 1}: {ocenki[i]}");
            }
        }

        Console.WriteLine($"Учеников с оценкой меньше средней: {count}");
    }
}