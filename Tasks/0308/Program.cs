using System;
class Program
{
    static void Main()
    {
        int sum = 0;
        int power = 1;

        for (int i = 1; i <= 10; i++)
        {
            power *= 2;
            if (i >= 2)
            {
                sum += power;
            }
        }

        Console.WriteLine($"{sum}");
    }
}