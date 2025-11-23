using System;
class Program
{
    static void Main()
    {
        int[] resultaty = { 125, 118, 132, 115, 128, 122, 135, 120, 130, 124, 138 };

        int min1 = resultaty[0];
        int min2 = int.MaxValue;

        for (int i = 1; i < resultaty.Length; i++)
        {
            if (resultaty[i] < min1)
            {
                min2 = min1;
                min1 = resultaty[i];
            }
            else if (resultaty[i] < min2 && resultaty[i] != min1)
            {
                min2 = resultaty[i];
            }
        }

        Console.WriteLine($"Первое место: {min1}");
        Console.WriteLine($"Второе место: {min2}");
    }
}