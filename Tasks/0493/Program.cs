using System;
class Program
{
    static void Main()
    {
        int count = 0;

        Console.Write("количество команд: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"команда {i} - выигрыши: ");
            int win = int.Parse(Console.ReadLine());

            Console.Write($"команда {i} - проигрыши: ");
            int lose = int.Parse(Console.ReadLine());

            if (win > lose) count++;
        }

        Console.WriteLine($"команд с больше выигрышей: {count}");
    }
}