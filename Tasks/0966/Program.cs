using System;
class Program
{
    static void Main()
    {
        int[] issledovatel1 = { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6 };
        int[] issledovatel2 = { 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7 };
        int[] resultat = new int[30];

        for (int i = 0; i < 30; i++)
        {
            if (i % 2 == 0)
            {
                resultat[i] = issledovatel1[i];
            }
            else
            {
                resultat[i] = issledovatel2[i];
            }
        }

        Console.Write("Общая таблица направления ветра: ");
        for (int i = 0; i < 30; i++)
        {
            Console.Write(resultat[i] + " ");
        }
    }
}