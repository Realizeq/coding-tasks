using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        int[] ves = new int[20];

        for (int i = 0; i < 20; i++)
        {
            ves[i] = rand.Next(50, 101);
        }

        Console.WriteLine("Веса 20 человек:");
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"Человек {i + 1}: {ves[i]} кг");
        }
    }
}