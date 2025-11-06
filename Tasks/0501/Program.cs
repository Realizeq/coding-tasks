using System;
class Program
{
    static void Main()
    {
        int count3 = 0;
        int count7 = 0;

        Console.Write("m: ");
        int m = int.Parse(Console.ReadLine());

        for (int i = 1; i <= m; i++)
        {
            Console.Write($"x{i}: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 3 == 0) count3++;
            if (x % 7 == 0) count7++;
        }

        Console.WriteLine($"кратных 3: {count3}");
        Console.WriteLine($"кратных 7: {count7}");
    }
}