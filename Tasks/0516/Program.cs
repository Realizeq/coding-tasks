using System;
class Program
{
    static void Main()
    {
        int count = 0;

        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("x: ");
        int x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"a{i}: ");
            int a = int.Parse(Console.ReadLine());

            if (a < 0) count++;
        }

        if (count > x) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}