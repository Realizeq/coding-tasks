using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        int kubik = rand.Next(1, 7);

        Console.WriteLine($"{kubik}");
    }
}