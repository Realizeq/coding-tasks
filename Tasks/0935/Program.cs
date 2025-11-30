using System;
class Program
{
    static void Main()
    {
        float[] ploshad = { 120, 150, 180, 200, 130, 160, 140, 170, 190, 110 };
        float[] urozhaynost = { 5, 6, 4, 5, 6, 5, 4, 5, 6, 5 };

        float vsegoPsh = 0;
        float vsegoPloshad = 0;

        for (int i = 0; i < 10; i++)
        {
            vsegoPsh += ploshad[i] * urozhaynost[i];
            vsegoPloshad += ploshad[i];
        }

        float sredUrozh = vsegoPsh / vsegoPloshad;
        Console.WriteLine($"Всего пшеницы: {vsegoPsh}");
        Console.WriteLine($"Средняя урожайность: {sredUrozh}");

        float[] pshRai = new float[10];
        float summPsh = 0;
        float summPloshad = 0;

        for (int i = 0; i < 10; i++)
        {
            pshRai[i] = ploshad[i] * urozhaynost[i];
            summPsh += pshRai[i];
            summPloshad += ploshad[i];
        }

        float sredUrozh2 = summPsh / summPloshad;
        Console.WriteLine($"Всего пшеницы (способ 2): {summPsh}");
        Console.WriteLine($"Средняя урожайность (способ 2): {sredUrozh2}");
    }
}