using System;
class Program
{
    static void Main()
    {
        int[] temperatura = { 5, 3, 7, 2, 4, 1, 6, 8, 3, 2, 5, 0, 4, 1, 7, 3, 6, 2, 5, 1, 4, 0, 3, 2, 6, 1, 5, 2 };

        int min1 = temperatura[0];
        int min2 = int.MaxValue;
        int index1 = 0;
        int index2 = -1;

        for (int i = 1; i < temperatura.Length; i++)
        {
            if (temperatura[i] < min1)
            {
                min2 = min1;
                min1 = temperatura[i];
                index2 = index1;
                index1 = i;
            }
            else if (temperatura[i] < min2 && temperatura[i] != min1)
            {
                min2 = temperatura[i];
                index2 = i;
            }
        }

        Console.WriteLine($"Самый холодный день: {index1 + 1} февраля, {min1}°C");
        Console.WriteLine($"Второй самый холодный день: {index2 + 1} февраля, {min2}°C");
    }
}