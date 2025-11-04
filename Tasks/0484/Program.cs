using System;
class Program
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("p: ");
        int p = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"c{i}: ");
            int c = int.Parse(Console.ReadLine());

            if (c <= m) sum += c;
        }

        if (sum % p == 0) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}