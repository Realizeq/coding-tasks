using System;
class Program
{
    static void Main()
    {
        int[] osadki = { 0, 5, 0, 3, 0, 0, 7, 2, 0, 4, 0, 1, 0, 6, 0, 0, 8, 0, 3, 0, 0, 2, 0, 5, 0, 0, 1, 0, 4, 0, 0 };

        Console.WriteLine("Дни без осадков:");
        for (int i = 0; i < osadki.Length; i++)
        {
            if (osadki[i] == 0)
            {
                Console.WriteLine($"{i + 1} января");
            }
        }
    }
}