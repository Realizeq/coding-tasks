using System;
class Program
{
    static void Main()
    {
        int[] rost = { 165, 172, 158, 180, 168, 175, 162, 178, 170, 167, 173, 160, 181 };

        int max = rost[0];
        int count = 1;

        for (int i = 1; i < rost.Length; i++)
        {
            if (rost[i] > max)
            {
                max = rost[i];
                count = 1;
            }
            else if (rost[i] == max)
            {
                count++;
            }
        }

        Console.WriteLine($"Человек с самым большим ростом: {count}");
    }
}