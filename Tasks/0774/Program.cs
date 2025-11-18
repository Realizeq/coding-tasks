using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, -8, 32, -12, 45, -3, 0, 27, -20, 10 };

        int summaPolozhitelnyh = 0;
        int summaOtritsatelnyh = 0;

        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] > 0)
            {
                summaPolozhitelnyh += massiv[i];
            }
            else if (massiv[i] < 0)
            {
                summaOtritsatelnyh += massiv[i];
            }
        }

        double chastnoe = (double)summaPolozhitelnyh / Math.Abs(summaOtritsatelnyh);

        Console.WriteLine($"Частное: {chastnoe}");
    }
}