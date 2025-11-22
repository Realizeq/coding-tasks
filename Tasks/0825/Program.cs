using System;

class Program
{
    static void Main()
    {
        int[] stoimost = { 450, 380, 520, 350, 480, 420, 550, };

        int min = stoimost[0];

        for (int i = 1; i < stoimost.Length; i++)
        {
            if (stoimost[i] < min)
            {
                min = stoimost[i];
            }
        }

        Console.WriteLine($"Самые дешевые конфеты стоят: {min}");
    }
}