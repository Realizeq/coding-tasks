using System;
class Program
{
    static void Main()
    {
        int count = 0;

        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"c{i}: ");
            int c = int.Parse(Console.ReadLine());

            if (c < 20) count++;
        }

        if (count == 5) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}