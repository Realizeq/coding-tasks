using System;
class Program
{
    static void Main()
    {
        int count = 0;

        for (int i = 1; i <= 12; i++)
        {
            Console.Write($"юноша {i}: ");
            int rost = int.Parse(Console.ReadLine());

            if (rost < 165) count++;
        }

        Console.WriteLine($"рост менее 165 см: {count}");
    }
}