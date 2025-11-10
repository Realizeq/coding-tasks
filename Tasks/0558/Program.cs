using System;
class Program
{
    static void Main()
    {
        int count = 0;
        int prev = int.Parse(Console.ReadLine());

        for (int j = 2; j <= 20; j++)
        {
            int current = int.Parse(Console.ReadLine());

            if (current == prev) count++;

            prev = current;
        }

        Console.WriteLine($"количество повторений: {count}");
    }
}