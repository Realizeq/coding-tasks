using System;
class Program
{
    static void Main()
    {
        int count = 0;

        Console.Write("количество учеников: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"ученик {i}: ");
            int ocenka = int.Parse(Console.ReadLine());

            if (ocenka == 5) count++;
        }

        Console.WriteLine($"количество пятерок: {count}");
    }
}