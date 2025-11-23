using System;
class Program
{
    static void Main()
    {
        int[] skorost = { 180, 220, 190, 240, 210, 230, 200, 250, 220, 260, 190 };

        int max1 = skorost[0];
        int max2 = int.MinValue;

        for (int i = 1; i < skorost.Length; i++)
        {
            if (skorost[i] > max1)
            {
                max2 = max1;
                max1 = skorost[i];
            }
            else if (skorost[i] > max2 && skorost[i] != max1)
            {
                max2 = skorost[i];
            }
        }

        Console.WriteLine($"Самый быстрый: {max1}");
        Console.WriteLine($"Второй самый быстрый: {max2}");
    }
}