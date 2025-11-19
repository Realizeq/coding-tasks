using System;
class Program
{
    static void Main()
    {
        int[] osadki = { 5, 0, 3, 7, 2, 0, 4, 1, 6, 0, 8, 3, 0, 2, 5, 0, 1, 4, 7, 0, 3, 6, 2, 0, 5, 1, 0, 4 };

        int count = 0;
        for (int i = 0; i < osadki.Length; i++)
        {
            if (osadki[i] == 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Дней без осадков: {count}");
    }
}