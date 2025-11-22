using System;
class Program
{
    static void Main()
    {
        int[] osadki = { 650, 720, 580, 690, 750, 630, 710, 670, 740, 590, 680, 760, 620, 700, 730 };

        int summa = 0;
        for (int i = 0; i < osadki.Length; i++)
        {
            summa += osadki[i];
        }

        double srednee = (double)summa / osadki.Length;

        Console.WriteLine($"Среднее количество осадков: {srednee}");

        for (int i = 0; i < osadki.Length; i++)
        {
            double otklonenie = osadki[i] - srednee;
            Console.WriteLine($"Год {i + 1}: {osadki[i]} мм, отклонение: {otklonenie} мм");
        }
    }
}