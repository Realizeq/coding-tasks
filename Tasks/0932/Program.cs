using System;
class Program
{
    static void Main()
    {
        float[] magazin1 = { 15000, 18000, 12000, 20000, 17000, 16000, 19000 };
        float[] magazin2 = { 14000, 16000, 13000, 18000, 15000, 17000, 16500 };

        float summ = 0;

        for (int i = 0; i < magazin1.Length; i++)
        {
            summ += magazin1[i];
        }

        for (int i = 0; i < magazin2.Length; i++)
        {
            summ += magazin2[i];
        }

        Console.WriteLine($"Общая стоимость товаров: {summ}");
    }
}