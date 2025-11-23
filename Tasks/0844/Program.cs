using System;
class Program
{
    static void Main()
    {
        int[] vozrast = { 25, 32, 18, 45, 29, 38, 22, 51, 27, 35 };

        int max = vozrast[0];
        int min = vozrast[0];
        int indexMax = 0;
        int indexMin = 0;

        for (int i = 1; i < vozrast.Length; i++)
        {
            if (vozrast[i] > max)
            {
                max = vozrast[i];
                indexMax = i;
            }
            if (vozrast[i] < min)
            {
                min = vozrast[i];
                indexMin = i;
            }
        }

        if (indexMin < indexMax)
        {
            Console.WriteLine("Раньше указан самый молодой");
        }
        else if (indexMax < indexMin)
        {
            Console.WriteLine("Раньше указан самый старый");
        }
        else
        {
            Console.WriteLine("Самый старый и самый молодой - один человек");
        }
    }
}