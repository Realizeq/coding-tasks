using System;
class Program
{
    static void Main()
    {
        int count = 1;

        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("число 1: ");
        int first = int.Parse(Console.ReadLine());

        for (int i = 2; i <= n; i++)
        {
            Console.Write($"число {i}: ");
            int num = int.Parse(Console.ReadLine());

            if (num != first) break;
            count++;
        }

        Console.WriteLine($"равных элементов в начале: {count}");
    }
}