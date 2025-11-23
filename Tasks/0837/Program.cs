using System;
class Program
{
    static void Main()
    {
        int[] stoimost = { 450, 380, 520, 350, 480, 420, 550, 370, 510, 390, 530, 360 };

        int min = stoimost[0];
        int count = 1;

        for (int i = 1; i < stoimost.Length; i++)
        {
            if (stoimost[i] < min)
            {
                min = stoimost[i];
                count = 1;
            }
            else if (stoimost[i] == min)
            {
                count++;
            }
        }

        Console.WriteLine($"Самых дешевых книг: {count}");
    }
}