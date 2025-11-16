using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        int[] rost = new int[12];

        for (int i = 0; i < 12; i++)
        {
            rost[i] = rand.Next(163, 191);
        }

        Console.WriteLine("Росты 12 человек:");
        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine($"Человек {i + 1}: {rost[i]} см");
        }
    }
}