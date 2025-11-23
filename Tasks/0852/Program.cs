using System;
class Program
{
    static void Main()
    {
        int[] ochki = { 45, 52, 38, 49, 56, 41, 47, 53, 39, 50, 44, 55, 42, 48, 54, 40, 46, 51, 43, 57 };

        int max1 = ochki[0];
        int max2 = int.MinValue;

        for (int i = 1; i < ochki.Length; i++)
        {
            if (ochki[i] > max1)
            {
                max2 = max1;
                max1 = ochki[i];
            }
            else if (ochki[i] > max2 && ochki[i] != max1)
            {
                max2 = ochki[i];
            }
        }

        Console.WriteLine($"Первое место: {max1} очков");
        Console.WriteLine($"Второе место: {max2} очков");
    }
}