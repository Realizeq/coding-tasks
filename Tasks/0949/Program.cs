using System;
class Program
{
    static void Main()
    {
        float[] massa = { 2.5f, 1.8f, 3.2f, 0.9f, 4.1f, 2.7f, 1.5f, 3.8f, 2.1f, 0.7f, 3.5f, 1.2f, 4.3f, 2.9f, 1.1f, 3.7f, 2.3f, 0.8f, 4.0f, 1.6f };
        float[] obem = { 500, 300, 400, 200, 600, 350, 250, 450, 320, 150, 420, 280, 550, 380, 240, 430, 310, 170, 480, 290 };

        float maxPlotnost = 0;

        for (int i = 0; i < 20; i++)
        {
            float plotnost = massa[i] * 1000 / obem[i];
            if (plotnost > maxPlotnost)
            {
                maxPlotnost = plotnost;
            }
        }

        Console.WriteLine($"Максимальная плотность: {maxPlotnost} г/смкуб");

        float[] plotnosti = new float[20];
        float maxPlotnost2 = 0;

        for (int i = 0; i < 20; i++)
        {
            plotnosti[i] = massa[i] * 1000 / obem[i];
            if (plotnosti[i] > maxPlotnost2)
            {
                maxPlotnost2 = plotnosti[i];
            }
        }

        Console.WriteLine($"Максимальная плотность (способ 2): {maxPlotnost2} г/смкуб");
    }
}