using System;
class Program
{
    static void Main()
    {
        int[] igry = { 3, 1, 3, 0, 1, 3, 0, 3, 1, 0, 3, 1, 3, 0, 1, 3, 0, 3, 1, 0 };

        int pobedi = 0;
        int nichya = 0;

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
        }

        Console.WriteLine($"Побед: {pobedi}");
        Console.WriteLine($"Ничьих: {nichya}");
    }
}