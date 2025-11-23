using System;
class Program
{
    static void Main()
    {
        int[] lyudi = { 25, 28, 30, 24, 26, 29, 27, 23, 25, 28, 30, 24, 26, 29, 27 };

        int min1 = lyudi[0];
        int min2 = int.MaxValue;
        int index1 = 0;
        int index2 = -1;

        for (int i = 1; i < lyudi.Length; i++)
        {
            if (lyudi[i] < min1)
            {
                min2 = min1;
                min1 = lyudi[i];
                index2 = index1;
                index1 = i;
            }
            else if (lyudi[i] < min2 && lyudi[i] != min1)
            {
                min2 = lyudi[i];
                index2 = i;
            }
        }

        Console.WriteLine($"Меньше всего людей на этаже: {index1 + 1}, {min1} человек");
        Console.WriteLine($"Второй меньше всего людей на этаже: {index2 + 1}, {min2} человек");
    }
}