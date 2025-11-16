using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        string[] masti = { "пик", "треф", "бубен", "червей" };
        string[] karty = { "шестерка", "семерка", "восьмерка", "девятка", "десятка", "валет", "дама", "король", "туз" };

        int kozirIndex = rand.Next(0, 4);
        Console.WriteLine($"Козырная масть: {masti[kozirIndex]}");

        int mast1 = rand.Next(0, 4);
        int karta1 = rand.Next(0, 9);
        int mast2 = rand.Next(0, 4);
        int karta2 = rand.Next(0, 9);

        Console.WriteLine($"Игрок 1: {karty[karta1]} {masti[mast1]}");
        Console.WriteLine($"Игрок 2: {karty[karta2]} {masti[mast2]}");

        if (mast1 == kozirIndex && mast2 != kozirIndex)
        {
            Console.WriteLine("Победил игрок 1 (козырь)");
        }
        else if (mast2 == kozirIndex && mast1 != kozirIndex)
        {
            Console.WriteLine("Победил игрок 2 (козырь)");
        }
        else if (mast1 == kozirIndex && mast2 == kozirIndex)
        {
            if (karta1 > karta2)
            {
                Console.WriteLine("Победил игрок 1");
            }
            else if (karta2 > karta1)
            {
                Console.WriteLine("Победил игрок 2");
            }
            else
            {
                Console.WriteLine("Ничья");
            }
        }
        else
        {
            if (mast1 > mast2)
            {
                Console.WriteLine("Победил игрок 1");
            }
            else if (mast2 > mast1)
            {
                Console.WriteLine("Победил игрок 2");
            }
            else
            {
                if (karta1 > karta2)
                {
                    Console.WriteLine("Победил игрок 1");
                }
                else if (karta2 > karta1)
                {
                    Console.WriteLine("Победил игрок 2");
                }
                else
                {
                    Console.WriteLine("Ничья");
                }
            }
        }
    }
}