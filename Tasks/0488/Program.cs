using System;
class Program
{
    static void Main()
    {
        int count = 0;

        for (int i = 1; i <= 30; i++)
        {
            Console.Write($"день {i}: ");
            int temp = int.Parse(Console.ReadLine());

            if (temp < 0) count++;
        }

        Console.WriteLine($"дней с температурой ниже 0: {count}");
    }
}