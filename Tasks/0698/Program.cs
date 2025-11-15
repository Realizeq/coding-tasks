using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.WriteLine("100:");
        int[] chasto100 = new int[6];

        for (int i = 0; i < 100; i++)
        {
            int kubik = rand.Next(1, 7);
            chasto100[kubik - 1]++;
        }

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"{i + 1}: {chasto100[i]} ({chasto100[i] / 100.0})");
        }

        Console.WriteLine("1000:");
        int[] chasto1000 = new int[6];

        for (int i = 0; i < 1000; i++)
        {
            int kubik = rand.Next(1, 7);
            chasto1000[kubik - 1]++;
        }

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"{i + 1}: {chasto1000[i]} ({chasto1000[i] / 1000.0})");
        }
    }
}