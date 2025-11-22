using System;

class Program
{
    static void Main()
    {
        int[] skorost = { 180, 220, 190, 240, 210, 230, 200, };

        int max = skorost[0];
        int indexFirst = 0;
        int indexLast = 0;

        for (int i = 1; i < skorost.Length; i++)
        {
            if (skorost[i] > max)
            {
                max = skorost[i];
                indexFirst = i;
                indexLast = i;
            }
            else if (skorost[i] == max)
            {
                indexLast = i;
            }
        }

        Console.WriteLine($"а) Первый самый быстрый: {indexFirst + 1}");
        Console.WriteLine($"б) Последний самый быстрый: {indexLast + 1}");
    }
}