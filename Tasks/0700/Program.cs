using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        int s1_1 = rand.Next(0, 7);
        int s1_2 = rand.Next(0, 7);
        int s2_1 = rand.Next(0, 7);
        int s2_2 = rand.Next(0, 7);

        Console.WriteLine($"Кость 1: {s1_1}-{s1_2}");
        Console.WriteLine($"Кость 2: {s2_1}-{s2_2}");

        if (s1_1 == s2_1 || s1_1 == s2_2 || s1_2 == s2_1 || s1_2 == s2_2)
        {
            Console.WriteLine("Кости можно приставить");
        }
        else
        {
            Console.WriteLine("Кости нельзя приставить");
        }
    }
}