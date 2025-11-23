using System;
class Program
{
    static void Main()
    {
        int[] osadki = { 5, 0, 3, 7, 2, 0, 4, 1, 6, 0, 8, 3, 0, };

        int max = osadki[0];
        int indexFirst = 0;
        int indexLast = 0;

        for (int i = 1; i < osadki.Length; i++)
        {
            if (osadki[i] > max)
            {
                max = osadki[i];
                indexFirst = i;
                indexLast = i;
            }
            else if (osadki[i] == max)
            {
                indexLast = i;
            }
        }

        Console.WriteLine($"а) Первый самый дождливый: {indexFirst + 1} июля");
        Console.WriteLine($"б) Последний самый дождливый: {indexLast + 1} июля");
    }
}