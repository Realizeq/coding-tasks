using System;
class Program
{
    static void Main()
    {
        int[] osadki = { 5, 0, 3, 7, 2, 0, 4, 1, 6, 0, 8, 3, 0, 2, 5, 0, 1, 4, 7, 0, 3, 6, 2, 0, 5, 1, 0, 4 };

        int summa = 0;
        for (int i = 1; i < osadki.Length; i += 2)
        {
            summa += osadki[i];
        }

        Console.WriteLine($"Осадки по четным числам: {summa}");
    }
}