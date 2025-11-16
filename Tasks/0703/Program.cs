using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        string[] masti = { "пик", "треф", "бубен", "червей" };
        string[] karty = { "шестерка", "семерка", "восьмерка", "девятка", "десятка", "валет", "дама", "король", "туз" };

        int mastIndex = rand.Next(0, 4);
        int kartaIndex = rand.Next(0, 9);

        Console.WriteLine($"Выбрана {karty[kartaIndex]} {masti[mastIndex]}");
    }
}