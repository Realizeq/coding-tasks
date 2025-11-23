using System;
class Program
{
    static void Main()
    {
        int[] osadki = { 5, 0, 3, 7, 2, 0, 4, 1, 6, 0, 8, 3, 0, 2 };

        int max = osadki[0];
        int count = 1;

        for (int i = 1; i < osadki.Length; i++)
        {
            if (osadki[i] > max)
            {
                max = osadki[i];
                count = 1;
            }
            else if (osadki[i] == max)
            {
                count++;
            }
        }

        Console.WriteLine($"Дней с максимальным количеством осадков: {count}");
    }
}