using System;
class Program
{
    static void Main()
    {
        int[] ocenki = { 5, 5, 5, 5, 5, 4, 4, 3, 4, 3, 2, 4, 3, 4, 5, 4, 3, 4, 4, 3, 2, 4, 3, 4, 5, 4, 3, 4 };

        Console.WriteLine("Оценки учеников:");
        for (int i = 0; i < ocenki.Length; i++)
        {
            Console.WriteLine($"{ocenki[i]}");
        }

        int countPyaterok = 0;
        while (countPyaterok < ocenki.Length && ocenki[countPyaterok] == 5)
        {
            countPyaterok++;
        }

        Console.WriteLine($"Учеников с оценкой '5': {countPyaterok}");

        if (countPyaterok == ocenki.Length)
        {
            Console.WriteLine("Все ученики имеют оценку '5'");
        }
    }
}