using System;
class Program
{
    static void Main()
    {
        int sum = 0;
        for (int i = 100; i <= 998; i += 2)
        {
            sum += i;
        }
        Console.WriteLine($"{sum}");
    }
}