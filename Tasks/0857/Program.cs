using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, -25, 8, -30, 12, 35, -18, 40, -5, 22 };

        int maxIndex = 0;
        int maxAbs = Math.Abs(massiv[0]);

        for (int i = 1; i < massiv.Length; i++)
        {
            int absValue = Math.Abs(massiv[i]);
            if (absValue > maxAbs)
            {
                maxAbs = absValue;
                maxIndex = i;
            }
        }

        massiv[maxIndex] = -massiv[maxIndex];

        Console.WriteLine("Массив после изменения:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }
    }
}