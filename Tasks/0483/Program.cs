using System;
class Program
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("q: ");
        int q = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"a{i}: ");
            int a = int.Parse(Console.ReadLine());

            if (a <= m) sum += a;
        }

        if (sum > q) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}