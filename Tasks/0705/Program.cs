using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        string[] masti = { "пик", "треф", "бубен", "червей" };
        string[] karty = { "шестерка", "семерка", "восьмерка", "девятка", "десятка", "валет", "дама", "король", "туз" };

        Console.Write("Введите количество раундов: ");
        int n = int.Parse(Console.ReadLine());

        int pobedi1 = 0;
        int pobedi2 = 0;
        int nichya = 0;

        for (int i = 0; i < n; i++)
        {
            int mast1 = rand.Next(0, 4);
            int karta1 = rand.Next(0, 9);
            int mast2 = rand.Next(0, 4);
            int karta2 = rand.Next(0, 9);

            Console.WriteLine($"Раунд {i + 1}:");
            Console.WriteLine($"Игрок 1: {karty[karta1]} {masti[mast1]}");
            Console.WriteLine($"Игрок 2: {karty[karta2]} {masti[mast2]}");

            if (mast1 > mast2)
            {
                Console.WriteLine("Победил игрок 1");
                pobedi1++;
            }
            else if (mast2 > mast1)
            {
                Console.WriteLine("Победил игрок 2");
                pobedi2++;
            }
            else
            {
                if (karta1 > karta2)
                {
                    Console.WriteLine("Победил игрок 1");
                    pobedi1++;
                }
                else if (karta2 > karta1)
                {
                    Console.WriteLine("Победил игрок 2");
                    pobedi2++;
                }
                else
                {
                    Console.WriteLine("Ничья");
                    nichya++;
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine($"Итог: Игрок 1 - {pobedi1}, Игрок 2 - {pobedi2}, Ничьих - {nichya}");

        if (pobedi1 > pobedi2)
        {
            Console.WriteLine("Общий победитель: игрок 1");
        }
        else if (pobedi2 > pobedi1)
        {
            Console.WriteLine("Общий победитель: игрок 2");
        }
        else
        {
            Console.WriteLine("Общая ничья");
        }
    }
}