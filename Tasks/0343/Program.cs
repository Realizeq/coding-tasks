using System;
class Program
{
    static void Main()
    {
        int count = 0;
        for (int i = 100; i <= 999; i++)
        {
            int sum = i / 100 + (i / 10) % 10 + i % 10;
            if (i % 7 == 0 && sum % 7 == 0)
            {
                count++;
            }
        }
        Console.WriteLine($"{count}");
    }
}