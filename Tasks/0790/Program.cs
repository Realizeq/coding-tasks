using System;
class Program
{
    static void Main()
    {
        int[] ocenki = { 5, 4, 3, 2, 5, 4, 3, 2, 5, 4, 3, 2, 5, 4, 3, 2, 5, 4, 3, 2, 5, 4 };

        int pyaterki = 0;
        int chetverki = 0;
        int troiki = 0;
        int dvoiki = 0;

        for (int i = 0; i < ocenki.Length; i++)
        {
            if (ocenki[i] == 5)
            {
                pyaterki++;
            }
            else if (ocenki[i] == 4)
            {
                chetverki++;
            }
            else if (ocenki[i] == 3)
            {
                troiki++;
            }
            else if (ocenki[i] == 2)
            {
                dvoiki++;
            }
        }

        Console.WriteLine($"Пятерок: {pyaterki}");
        Console.WriteLine($"Четверок: {chetverki}");
        Console.WriteLine($"Троек: {troiki}");
        Console.WriteLine($"Двоек: {dvoiki}");
    }
}