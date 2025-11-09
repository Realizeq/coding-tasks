using System;
class Program
{
    static void Main()
    {
        int last_index = 0;

        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"b{i}: ");
            int b = int.Parse(Console.ReadLine());

            if (b > 100) last_index = i;
        }

        Console.WriteLine($"номер последнего: {last_index}");
    }
}