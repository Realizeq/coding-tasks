using System;
class Program
{
    static void Main()
    {
        int[] stoimost = { 150, 230, 75, 420, 180, 95, 310, 125, 280, 65, 390, 110, 340, 200, 450, 80, 260, 170, 380, 90 };

        int summa = 0;
        for (int i = 0; i < stoimost.Length; i++)
        {
            summa += stoimost[i];
        }

        double srednee = (double)summa / stoimost.Length;

        int count = 0;
        for (int i = 0; i < stoimost.Length; i++)
        {
            if (stoimost[i] < srednee)
            {
                count++;
            }
        }

        Console.WriteLine($"Видов товара дешевле средней стоимости: {count}");
    }
}