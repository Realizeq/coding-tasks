using System;
class Program
{
    static void Main()
    {
        int[] igry = { 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1 };

        int pobedi = 0;
        int nichya = 0;
        int porazheniya = 0;

        for (int i = 0; i < igry.Length; i++)
        {
            if (igry[i] == 3)
            {
                pobedi++;
            }
            else if (igry[i] == 1)
            {
                nichya++;
            }
            else if (igry[i] == 2)
            {
                porazheniya++;
            }
        }

        Console.WriteLine($"Побед: {pobedi}");
        Console.WriteLine($"Ничьих: {nichya}");
        Console.WriteLine($"Проигрышей: {porazheniya}");
    }
}