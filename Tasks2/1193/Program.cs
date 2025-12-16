using System;
class Program
{
    static void Main()
    {
        float[] massa = {2.5f, 1.8f, 3.2f, 0.9f, 4.1f, 2.7f, 1.5f, 3.8f, 2.1f, 0.7f,
                        3.5f, 1.2f, 4.3f, 2.9f, 1.1f, 3.7f, 2.3f, 0.8f, 4.0f, 1.6f,
                        2.8f, 1.4f, 3.9f, 2.2f, 1.0f, 3.6f, 2.0f, 0.6f, 4.2f, 1.3f};

        float[] obem = {500, 300, 400, 200, 600, 350, 250, 450, 320, 150,
                       420, 280, 550, 380, 240, 430, 310, 170, 480, 290,
                       360, 260, 490, 330, 210, 440, 300, 140, 520, 270};

        float maxPlotnost = 0;
        int indexMax = -1;

        for (int i = 0; i < 30; i++)
        {
            float plotnost = massa[i] * 1000 / obem[i];
            if (plotnost > maxPlotnost)
            {
                maxPlotnost = plotnost;
                indexMax = i;
            }
        }

        Console.WriteLine($"Максимальная плотность: {maxPlotnost:F2} г/см³");
        Console.WriteLine($"Номер предмета с максимальной плотностью: {indexMax + 1}");
    }
}