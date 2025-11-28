using System;
class Program
{
    static void Main()
    {
        int[] chisla = { 3, 7, 12, 5, 9, 15, 8, 4, 11, 6, 13, 2, 10, 14, 1, 7, 16, 18, 17, 19 };

        int povtor = 0;

        for (int i = 0; i < chisla.Length; i++)
        {
            for (int j = i + 1; j < chisla.Length; j++)
            {
                if (chisla[i] == chisla[j])
                {
                    povtor = chisla[i];
                    break;
                }
            }
        }

        Console.WriteLine($"Повторяющийся элемент: {povtor}");
    }
}