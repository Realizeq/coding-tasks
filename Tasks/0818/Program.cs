using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 10, -4, 12, 56, -4, -89, 23, -15, 42, -7 };

        int smenaZnaka = 0;

        for (int i = 0; i < massiv.Length - 1; i++)
        {
            if (massiv[i] * massiv[i + 1] < 0)
            {
                smenaZnaka++;
            }
        }

        Console.WriteLine($"Смена знака: {smenaZnaka} раз");
    }
}