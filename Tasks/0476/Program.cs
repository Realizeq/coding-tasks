using System;
class Program
{
    static void Main()
    {
        int total = 0;

        Console.Write("количество газет и журналов: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"издание {i}: ");
            int pages = int.Parse(Console.ReadLine());
            if (pages > 16)
            {
                total += pages;
            }
        }

        Console.WriteLine($"общее число страниц в журналах: {total}");
    }
}