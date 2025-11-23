using System;
class Program
{
    static void Main()
    {
        int[] veter = { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8 };

        int[] chastota = new int[9];

        for (int i = 0; i < veter.Length; i++)
        {
            chastota[veter[i]]++;
        }

        int minChastota = chastota[1];
        int napravlenieMin = 1;

        for (int i = 2; i <= 8; i++)
        {
            if (chastota[i] < minChastota)
            {
                minChastota = chastota[i];
                napravlenieMin = i;
            }
        }

        Console.WriteLine($"Жилой комплекс должен быть расположен с направления: {napravlenieMin}");
    }
}