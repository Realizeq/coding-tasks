using System;
class Program
{
    static void Main()
    {
        int[] osadki = { 5, 0, 3, 7, 2, 0, 4, 1, 6, 0, 8, 3, 0, 2, 5, 0, 1, 4, 7, 0, 3, 6, 2, 0, 5, 1, 0, 4, 2, 3 };

        int pervayaDecada = 0;
        int vtorayaDecada = 0;
        int tretiyaDecada = 0;

        for (int i = 0; i < 10; i++)
        {
            pervayaDecada += osadki[i];
        }

        for (int i = 10; i < 20; i++)
        {
            vtorayaDecada += osadki[i];
        }

        for (int i = 20; i < 30; i++)
        {
            tretiyaDecada += osadki[i];
        }

        Console.WriteLine($"Первая декада: {pervayaDecada}");
        Console.WriteLine($"Вторая декада: {vtorayaDecada}");
        Console.WriteLine($"Третья декада: {tretiyaDecada}");
    }
}