using System;
class Program
{
    static void Main()
    {
        int count = 0;

        for (int i = 1; i <= 20; i++)
        {
            Console.Write($"ученик {i}: ");
            int ocenka = int.Parse(Console.ReadLine());

            if (ocenka != 5) break;
            count++;
        }

        Console.WriteLine($"учеников с пятеркой: {count}");
    }
}