using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        int igrok1 = rand.Next(1, 7);
        int igrok2 = rand.Next(1, 7);

        Console.WriteLine($"Игрок 1: {igrok1}");
        Console.WriteLine($"Игрок 2: {igrok2}");

        if (igrok1 > igrok2)
        {
            Console.WriteLine("Победил игрок 1");
        }
        else if (igrok2 > igrok1)
        {
            Console.WriteLine("Победил игрок 2");
        }
        else
        {
            Console.WriteLine("Ничья");
        }
    }
}