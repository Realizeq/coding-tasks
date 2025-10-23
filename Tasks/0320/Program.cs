using System;
class Program
{
    static void Main()
    {
        int sum = 0;
        for (int n = 1; n <= 12; n++)
        {
            int square = 0;
            for (int i = 1; i <= 2 * n - 1; i += 2)
            {
                square += i;
            }
            sum += square;
        }

        Console.WriteLine($"{sum}");
    }
}