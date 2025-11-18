using System;
class Program
{
    static void Main()
    {
        int[] stoimost = { 150, 230, 75, 420, 180, 95, 310, 125, 280, 65, 390, 110 };

        int summa = 0;
        for (int i = 0; i < stoimost.Length; i++)
        {
            summa += stoimost[i];
        }

        Console.WriteLine($"Общая стоимость: {summa}");
    }
}