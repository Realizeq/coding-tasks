using System;
class Program
{
    static void Main()
    {
        int[] ocenki = { 5, 4, 3, 5, 4, 2, 5, 4, 3, 5 };

        int chetverki = 0;
        int pyaterki = 0;

        for (int i = 0; i < ocenki.Length; i++)
        {
            if (ocenki[i] == 4)
            {
                chetverki++;
            }
            else if (ocenki[i] == 5)
            {
                pyaterki++;
            }
        }

        Console.WriteLine($"Четверок: {chetverki}");
        Console.WriteLine($"Пятерок: {pyaterki}");
    }
}