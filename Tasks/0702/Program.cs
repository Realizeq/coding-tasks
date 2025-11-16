using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        string[] karty = { "6", "7", "8", "9", "10", "валет", "дама", "король", "туз" };

        int index = rand.Next(0, 9);

        Console.WriteLine($"Выбрана карта {karty[index]}");
    }
}