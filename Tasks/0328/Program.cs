using System;
class Program
{
    static void Main()
    {
        // с условным оператором
        for (int i = 10; i <= 100; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write($"{i} ");
            }
        }

        Console.WriteLine();

        // без
        for (int i = 11; i <= 100; i += 2)
        {
            Console.Write($"{i} ");
        }
    }
}