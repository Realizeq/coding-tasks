using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.WriteLine("1) Два броска каждым:");
        int summa1 = 0;
        int summa2 = 0;

        for (int i = 0; i < 2; i++)
        {
            summa1 += rand.Next(1, 7);
            summa2 += rand.Next(1, 7);
        }

        Console.WriteLine($"Игрок 1: {summa1}");
        Console.WriteLine($"Игрок 2: {summa2}");

        if (summa1 > summa2)
        {
            Console.WriteLine("Победил игрок 1");
        }
        else if (summa2 > summa1)
        {
            Console.WriteLine("Победил игрок 2");
        }
        else
        {
            Console.WriteLine("Ничья");
        }

        Console.WriteLine("2) Несколько раундов:");
        Console.Write("Введите количество раундов: ");
        int n = int.Parse(Console.ReadLine());

        int pobedi1 = 0;
        int pobedi2 = 0;
        int nichya = 0;

        for (int i = 0; i < n; i++)
        {
            int kubik1 = rand.Next(1, 7);
            int kubik2 = rand.Next(1, 7);

            if (kubik1 > kubik2)
            {
                pobedi1++;
            }
            else if (kubik2 > kubik1)
            {
                pobedi2++;
            }
            else
            {
                nichya++;
            }
        }

        Console.WriteLine($"Игрок 1: {pobedi1} побед");
        Console.WriteLine($"Игрок 2: {pobedi2} побед");
        Console.WriteLine($"Ничьих: {nichya}");

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