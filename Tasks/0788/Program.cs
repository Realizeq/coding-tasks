using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 24, 35, 42, 55, 68, 75, 86, 95, 100 };

        int chetnye = 0;
        int okanchivayutsyaNa5 = 0;

        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % 2 == 0)
            {
                chetnye++;
            }
            if (massiv[i] % 10 == 5)
            {
                okanchivayutsyaNa5++;
            }
        }

        Console.WriteLine($"Четных: {chetnye}");
        Console.WriteLine($"Оканчивающихся на 5: {okanchivayutsyaNa5}");
    }
}