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
            Console.Write($"c{i}: ");
            int c = int.Parse(Console.ReadLine());

            if (c == 25) last_index = i;
        }

        if (last_index > 0) Console.WriteLine($"номер последнего: {last_index}");
        else Console.WriteLine("числа 25 нет");
    }
}