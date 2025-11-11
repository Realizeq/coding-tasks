using System;
class Program
{
    static void Main()
    {
        int first = 0;
        int second = 0;
        int third = 0;

        for (int j = 1; j <= 12; j++)
        {
            Console.Write($"команда {j}: ");
            int points = int.Parse(Console.ReadLine());

            if (points > first)
            {
                third = second;
                second = first;
                first = points;
            }
            else if (points > second)
            {
                third = second;
                second = points;
            }
            else if (points > third)
            {
                third = points;
            }
        }

        Console.WriteLine($"первое место: {first}");
        Console.WriteLine($"второе место: {second}");
        Console.WriteLine($"третье место: {third}");
    }
}