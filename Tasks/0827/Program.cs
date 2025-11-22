using System;
class Program
{
    static void Main()
    {
        int[] rost = { 165, 172, 158, 180, 168, 175, 162, 178, 170, 167, 173, 160, 181, 169, 176, 163, 179, 171, 166, 174, 161, 177, 182, 164, 183 };

        int max = rost[0];
        int min = rost[0];

        for (int i = 1; i < rost.Length; i++)
        {
            if (rost[i] > max)
            {
                max = rost[i];
            }
            if (rost[i] < min)
            {
                min = rost[i];
            }
        }

        int raznica = max - min;

        Console.WriteLine($"Самый высокий выше самого низкого на: {raznica} см");
    }
}