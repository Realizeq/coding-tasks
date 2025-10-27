using System;
class Program
{
    static void Main()
    {
        int sum = 0;
        for (int i = 31; i < 100; i++)
        {
            int lastDigit = i % 10;
            if (i % 3 == 0 && (lastDigit == 2 || lastDigit == 4 || lastDigit == 8))
            {
                sum += i;
            }
        }
        Console.WriteLine($"{sum}");
    }
}