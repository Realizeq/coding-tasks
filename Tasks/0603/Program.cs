using System;
class Program
{
    static void Main()
    {
        double min1 = double.MaxValue;
        double min2 = double.MaxValue;
        int day1 = 0;
        int day2 = 0;

        for (int j = 1; j <= 31; j++)
        {
            Console.Write($"день {j}: ");
            double temp = double.Parse(Console.ReadLine());

            if (temp < min1)
            {
                min2 = min1;
                min1 = temp;
                day2 = day1;
                day1 = j;
            }
            else if (temp < min2)
            {
                min2 = temp;
                day2 = j;
            }
        }

        Console.WriteLine($"самый прохладный день: {day1}");
        Console.WriteLine($"второй прохладный день: {day2}");
    }
}