using System;
class Program
{
    static void Main()
    {
        float[] dlina = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        float[] shirina = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        float[] vysota = { 0.5f, 1, 1.5f, 2, 2.5f, 3, 3.5f, 4, 4.5f, 5, 5.5f, 6 };

        for (int i = 0; i < 12; i++)
        {
            float obem = dlina[i] * shirina[i] * vysota[i];
            Console.WriteLine($"Параллелепипед {i + 1}: {obem}");
        }

        float[] obema = new float[12];

        for (int i = 0; i < 12; i++)
        {
            obema[i] = dlina[i] * shirina[i] * vysota[i];
            Console.WriteLine($"Параллелепипед {i + 1} (способ 2): {obema[i]}");
        }
    }
}