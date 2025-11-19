using System;
class Program
{
    static void Main()
    {
        int[] rost = { 165, 172, 158, 180, 168, 175, 162, 178, 170, 167, 173, 160, 181, 169, 176, 163, 179, 171, 166, 174, 161, 177 };

        Console.Write("Введите r: ");
        int r = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = 0; i < rost.Length; i++)
        {
            if (rost[i] <= r)
            {
                count++;
            }
        }

        Console.WriteLine($"Учеников с ростом <= {r}: {count}");
    }
}