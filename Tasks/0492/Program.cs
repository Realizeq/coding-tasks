using System;
class Program
{
    static void Main()
    {
        int countBefore = 0;
        int countAfter = 0;

        Console.Write("количество людей: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"человек {i}: ");
            int year = int.Parse(Console.ReadLine());

            if (year < 1990) countBefore++;
            if (year > 2000) countAfter++;
        }

        Console.WriteLine($"до 1990: {countBefore}");
        Console.WriteLine($"после 2000: {countAfter}");
    }
}