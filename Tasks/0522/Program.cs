using System;
class Program
{
    static void Main()
    {
        int count = 0;

        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        int prev = int.Parse(Console.ReadLine());
        int current = int.Parse(Console.ReadLine());

        for (int i = 3; i <= n; i++)
        {
            int next = int.Parse(Console.ReadLine());

            if (current > prev && current > next) count++;

            prev = current;
            current = next;
        }

        Console.WriteLine($"локальных максимумов: {count}");
    }
}