using System;
class Program
{
    static void Main()
    {
        int[] ves = { 65, 85, 70, 90, 55, 75, 80, 95, 60, 100 };

        int max = ves[0];
        int min = ves[0];

        for (int i = 1; i < ves.Length; i++)
        {
            if (ves[i] > max)
            {
                max = ves[i];
            }
            if (ves[i] < min)
            {
                min = ves[i];
            }
        }

        if (max > min * 2)
        {
            Console.WriteLine("самый тяжелый тяжелее самого легкого более чем в 2 раза");
        }
        else
        {
            Console.WriteLine("самый тяжелый не тяжелее самого легкого более чем в 2 раза");
        }
    }
}