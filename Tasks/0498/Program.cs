using System;
class Program
{
    static void Main()
    {
        int count = 1;

        for (int i = 2; i <= 31; i++)
        {
            Console.Write($"день {i}: ");
            int osadki = int.Parse(Console.ReadLine());

            if (osadki > 0) break;
            count++;
        }

        Console.WriteLine($"дней без осадков с начала мая: {count}");
    }
}