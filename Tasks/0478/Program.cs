using System;
class Program
{
    static void Main()
    {
        int total = 0;

        for (int i = 1; i <= 11; i++)
        {
            Console.Write($"класс {i}: ");
            int children = int.Parse(Console.ReadLine());
            if (i % 2 == 1)
            {
                total += children;
            }
        }

        Console.WriteLine($"общее число детей в нечетных классах: {total}");
    }
}