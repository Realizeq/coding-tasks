using System;
class Program
{
    static void Main()
    {
        int[] stoimost = { 450, 380, 520, 350, 480, 420, 550, 370, 510 };

        int max1 = stoimost[0];
        int max2 = int.MinValue;

        for (int i = 1; i < stoimost.Length; i++)
        {
            if (stoimost[i] > max1)
            {
                max2 = max1;
                max1 = stoimost[i];
            }
            else if (stoimost[i] > max2 && stoimost[i] != max1)
            {
                max2 = stoimost[i];
            }
        }

        Console.WriteLine($"Самый дорогой: {max1}");
        Console.WriteLine($"Второй самый дорогой: {max2}");
    }
}