using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.Write("Введите K: ");
        int K = int.Parse(Console.ReadLine());

        int summa1 = 0;
        int summa2 = 0;
        int summa3 = 0;

        for (int i = 0; i < K; i++)
        {
            summa1 += rand.Next(1, 7);
            summa2 += rand.Next(1, 7);
            summa3 += rand.Next(1, 7);
        }

        Console.WriteLine($"Игрок 1: {summa1}");
        Console.WriteLine($"Игрок 2: {summa2}");
        Console.WriteLine($"Игрок 3: {summa3}");

        if (summa1 > summa2 && summa1 > summa3)
        {
            Console.WriteLine("Победил игрок 1");
        }
        else if (summa2 > summa1 && summa2 > summa3)
        {
            Console.WriteLine("Победил игрок 2");
        }
        else if (summa3 > summa1 && summa3 > summa2)
        {
            Console.WriteLine("Победил игрок 3");
        }
        else
        {
            Console.WriteLine("Ничья между несколькими игроками");
        }
    }
}