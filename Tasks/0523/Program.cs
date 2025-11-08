using System;
class Program
{
    static void Main()
    {
        int count = 0;

        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        int prev = int.Parse(Console.ReadLine());

        for (int i = 2; i <= n; i++)
        {
            int current = int.Parse(Console.ReadLine());

            if (prev * current < 0) count++;

            prev = current;
        }

        Console.WriteLine($"смен знака: {count}");
    }
}