using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        int sposobi = 0;

        for (int k10 = 0; k10 <= n / 10; k10++)
        {
            for (int k5 = 0; k5 <= (n - k10 * 10) / 5; k5++)
            {
                for (int k2 = 0; k2 <= (n - k10 * 10 - k5 * 5) / 2; k2++)
                {
                    int k1 = n - k10 * 10 - k5 * 5 - k2 * 2;
                    if (k1 >= 0)
                    {
                        sposobi++;
                    }
                }
            }
        }

        Console.WriteLine($"Число способов выплаты: {sposobi}");

        Console.WriteLine("Все способы выплаты:");
        for (int k10 = 0; k10 <= n / 10; k10++)
        {
            for (int k5 = 0; k5 <= (n - k10 * 10) / 5; k5++)
            {
                for (int k2 = 0; k2 <= (n - k10 * 10 - k5 * 5) / 2; k2++)
                {
                    int k1 = n - k10 * 10 - k5 * 5 - k2 * 2;
                    if (k1 >= 0)
                    {
                        Console.WriteLine($"{k1} по 1 руб, {k2} по 2 руб, {k5} по 5 руб, {k10} по 10 руб");
                    }
                }
            }
        }
    }
}