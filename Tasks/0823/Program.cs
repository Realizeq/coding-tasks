using System;

class Program
{
    static void Main()
    {
        int[] stranicy = { 245, 387, 156, 542, 289, 674, };

        int max = stranicy[0];

        for (int i = 1; i < stranicy.Length; i++)
        {
            if (stranicy[i] > max)
            {
                max = stranicy[i];
            }
        }

        Console.WriteLine($"Страниц в самой толстой книге: {max}");
    }
}