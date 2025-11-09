using System;
class Program
{
    static void Main()
    {
        bool ordered = true;

        Console.Write("количество команд: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("команда 1: ");
        int prev = int.Parse(Console.ReadLine());

        for (int i = 2; i <= n; i++)
        {
            Console.Write($"команда {i}: ");
            int current = int.Parse(Console.ReadLine());

            if (current > prev) ordered = false;

            prev = current;
        }

        if (ordered) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}