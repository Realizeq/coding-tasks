using System;
class Program
{
    static void Main()
    {
        float[] osadki = { 2.5f, 0, 1.2f, 3.7f, 0.8f, 2.1f, 0, 4.3f, 1.5f, 0.7f, 3.2f, 0, 2.8f, 1.1f, 0.9f, 0, 2.4f, 3.9f, 1.8f, 0.6f, 2.7f, 0, 1.4f, 3.5f, 0.5f, 2.2f, 0, 4.1f, 1.7f, 0.8f };
        float[] temp = { 5, -2, 3, -5, 2, -3, 1, -7, 4, -1, 6, -4, 2, -2, 3, 0, 5, -6, 4, -1, 3, -3, 2, -4, 1, -2, 4, -5, 3, -1 };

        float dozhd = 0;
        float sneg = 0;

        for (int i = 0; i < 30; i++)
        {
            if (temp[i] > 0)
            {
                dozhd += osadki[i];
            }
            else
            {
                sneg += osadki[i];
            }
        }

        Console.WriteLine($"Осадков в виде дождя: {dozhd} мм");
        Console.WriteLine($"Осадков в виде снега: {sneg} мм");
    }
}