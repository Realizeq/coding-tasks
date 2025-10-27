using System;
class Program
{
    static void Main()
    {
        int count = 0;
        for (int i = 100; i <= 500; i++)
        {
            int sum = i / 100 + (i / 10) % 10 + i % 10;
            if (sum == 15)
            {
                count++;
            }
        }
        Console.WriteLine($"{count}");
    }
}