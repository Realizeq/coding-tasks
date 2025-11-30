using System;
class Program
{
    static void Main()
    {
        float[] dlina = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        float[] shirina = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        float[] vysota = { 0.5f, 1, 1.5f, 2, 2.5f, 3, 3.5f, 4, 4.5f, 5, 5.5f, 6, 6.5f, 7, 7.5f };

        float maxObem = 0;
        float minObem = float.MaxValue;
        int nomerMax = 0;
        int nomerMin = 0;

        for (int i = 0; i < 15; i++)
        {
            float obem = dlina[i] * shirina[i] * vysota[i];
            if (obem > maxObem)
            {
                maxObem = obem;
                nomerMax = i + 1;
            }
            if (obem < minObem)
            {
                minObem = obem;
                nomerMin = i + 1;
            }
        }

        Console.WriteLine($"Максимальный объем: {maxObem}");
        Console.WriteLine($"Минимальный объем: {minObem}");
        Console.WriteLine($"Номер фигуры с максимальным объемом: {nomerMax}");
        Console.WriteLine($"Номер фигуры с минимальным объемом: {nomerMin}");

        float[] obema = new float[15];
        float maxObem2 = 0;
        float minObem2 = float.MaxValue;
        int nomerMax2 = 0;
        int nomerMin2 = 0;

        for (int i = 0; i < 15; i++)
        {
            obema[i] = dlina[i] * shirina[i] * vysota[i];
            if (obema[i] > maxObem2)
            {
                maxObem2 = obema[i];
                nomerMax2 = i + 1;
            }
            if (obema[i] < minObem2)
            {
                minObem2 = obema[i];
                nomerMin2 = i + 1;
            }
        }

        Console.WriteLine($"Максимальный объем (способ 2): {maxObem2}");
        Console.WriteLine($"Минимальный объем (способ 2): {minObem2}");
        Console.WriteLine($"Номер фигуры с максимальным объемом (способ 2): {nomerMax2}");
        Console.WriteLine($"Номер фигуры с минимальным объемом (способ 2): {nomerMin2}");
    }
}