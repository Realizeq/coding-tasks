using System;
class Program
{
    static void Main()
    {
        float[] yanvar = { 2.5f, 0, 1.2f, 3.7f, 0.8f, 2.1f, 0, 4.3f, 1.5f, 0.7f, 3.2f, 0, 2.8f, 1.1f, 0.9f, 0, 2.4f, 3.9f, 1.8f, 0.6f, 2.7f, 0, 1.4f, 3.5f, 0.5f, 2.2f, 0, 4.1f, 1.7f, 0.8f, 2.9f };
        float[] mart = { 1.8f, 2.3f, 0.9f, 3.1f, 1.2f, 2.7f, 0.5f, 3.8f, 1.1f, 2.4f, 0.7f, 3.3f, 1.5f, 2.9f, 0.8f, 3.5f, 1.3f, 2.6f, 0.6f, 3.7f, 1.4f, 2.8f, 0.9f, 3.2f, 1.6f, 2.5f, 0.7f, 3.9f, 1.2f, 2.1f, 0.8f };

        float summYanvar = 0;
        float summMart = 0;

        for (int i = 0; i < 31; i++)
        {
            summYanvar += yanvar[i];
            summMart += mart[i];
        }

        if (summYanvar > summMart)
        {
            Console.WriteLine($"В январе выпало больше осадков: {summYanvar} мм");
        }
        else if (summMart > summYanvar)
        {
            Console.WriteLine($"В марте выпало больше осадков: {summMart} мм");
        }
        else
        {
            Console.WriteLine($"Осадков выпало одинаково: {summYanvar} мм");
        }
    }
}