using System;
class Program
{
    static void Main()
    {
        int sum = 0;
        for (int i = 1; i < 50; i += 2)
        {
            sum += i;
        }
        Console.WriteLine($"{sum}");
    }
}