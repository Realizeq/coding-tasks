using System;
class Program
{
    static void Main()
    {
        int sum = 0;
        int sign = -1; // для знака отриц

        for (int i = 1; i <= 10; i++)
        {
            int square = i * i;
            sum += sign * square;
            sign = -sign;
        }

        Console.WriteLine($"{sum}");
    }
}