using System;

class Program
{
    static void Main()
    {
        int[] stoimost = { 25000, 30000, 35000, 28000, 32000, 40000, 45000, };

        int max = stoimost[0];

        for (int i = 1; i < stoimost.Length; i++)
        {
            if (stoimost[i] > max)
            {
                max = stoimost[i];
            }
        }

        Console.WriteLine($"Самый дорогой автомобиль стоит: {max}");
    }
}