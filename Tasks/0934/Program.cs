using System;
class Program
{
    static void Main()
    {
        float[] ploshad = { 120, 150, 180, 200, 130, 160, 140, 170, 190, 110, 125, 135, 145, 155, 165, 175, 185, 195, 205, 115 };
        float[] urozhay = { 600, 750, 900, 1000, 650, 800, 700, 850, 950, 550, 625, 675, 725, 775, 825, 875, 925, 975, 1025, 575 };

        float vsegoUrozhay = 0;
        float vsegoPloshad = 0;

        Console.WriteLine("Урожайность по районам:");
        for (int i = 0; i < 20; i++)
        {
            float urozhaynost = urozhay[i] / ploshad[i];
            Console.WriteLine($"Район {i + 1}: {urozhaynost}");
            vsegoUrozhay += urozhay[i];
            vsegoPloshad += ploshad[i];
        }

        float srednyaya = vsegoUrozhay / vsegoPloshad;
        Console.WriteLine($"Средняя урожайность по области: {srednyaya}");

        float[] urozhaynostMassiv = new float[20];
        float summUrozhaynost = 0;

        for (int i = 0; i < 20; i++)
        {
            urozhaynostMassiv[i] = urozhay[i] / ploshad[i];
            summUrozhaynost += urozhaynostMassiv[i];
        }

        float srednyaya2 = summUrozhaynost / 20;
        Console.WriteLine($"Средняя урожайность по области (способ 2): {srednyaya2}");
    }
}