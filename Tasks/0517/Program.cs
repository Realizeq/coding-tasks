using System;
class Program
{
    static void Main()
    {
        int count = 0;

        Console.Write("m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("p: ");
        int p = int.Parse(Console.ReadLine());

        for (int i = 1; i <= m; i++)
        {
            Console.Write($"a{i}: ");
            int a = int.Parse(Console.ReadLine());

            if (a > m) count++;
        }

        if (count % p == 0) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}