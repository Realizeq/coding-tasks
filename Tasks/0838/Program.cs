using System;
class Program
{
    static void Main()
    {
        int[] temperatura = { 25, 28, 30, 32, 29, 27, 26, 31, 33, 34, 30, 28 };

        int min = temperatura[0];
        int count = 1;

        for (int i = 1; i < temperatura.Length; i++)
        {
            if (temperatura[i] < min)
            {
                min = temperatura[i];
                count = 1;
            }
            else if (temperatura[i] == min)
            {
                count++;
            }
        }

        Console.WriteLine($"Самых прохладных дней: {count}");
    }
}