using System;
class Program
{
    static void Main()
    {
        int[] temperatura = { 25, 28, 30, 32, 29, 27, 26, 31, 33, 34, 30, 28, 29, 32, 35, 33, 31, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20, 19, 18, 17 };

        int max1 = temperatura[0];
        int max2 = int.MinValue;
        int index1 = 0;
        int index2 = -1;

        for (int i = 1; i < temperatura.Length; i++)
        {
            if (temperatura[i] > max1)
            {
                max2 = max1;
                max1 = temperatura[i];
                index2 = index1;
                index1 = i;
            }
            else if (temperatura[i] > max2 && temperatura[i] != max1)
            {
                max2 = temperatura[i];
                index2 = i;
            }
        }

        Console.WriteLine($"Самый теплый день: {index1 + 1} июля, {max1}°C");
        Console.WriteLine($"Второй самый теплый день: {index2 + 1} июля, {max2}°C");
    }
}