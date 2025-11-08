using System;
class Program
{
    static void Main()
    {
        int count = 0;

        Console.Write("m: ");
        int m = int.Parse(Console.ReadLine());

        for (int i = 1; i <= m; i++)
        {
            Console.Write($"d{i}: ");
            int d = int.Parse(Console.ReadLine());

            if (d > 0) count++;
        }

        if (count % 3 == 0) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}