using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        int storona1 = rand.Next(0, 7);
        int storona2 = rand.Next(0, 7);

        Console.WriteLine($"Выбрана кость {storona1}-{storona2}");
    }
}