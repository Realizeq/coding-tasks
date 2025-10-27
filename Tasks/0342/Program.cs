using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите s (0 < s <= 27): ");
        int s = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = 100; i <= 999; i++)
        {
            int sum = i / 100 + (i / 10) % 10 + i % 10;
            if (sum == s)
            {
                count++;
            }
        }
        Console.WriteLine($"{count}");
    }
}