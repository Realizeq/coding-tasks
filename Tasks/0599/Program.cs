using System;
class Program
{
    static void Main()
    {
        double first = double.MaxValue;
        double second = double.MaxValue;

        for (int j = 1; j <= 22; j++)
        {
            Console.Write($"спортсмен {j}: ");
            double time = double.Parse(Console.ReadLine());

            if (time < first)
            {
                second = first;
                first = time;
            }
            else if (time < second)
            {
                second = time;
            }
        }

        Console.WriteLine($"первое место: {first}");
        Console.WriteLine($"второе место: {second}");
    }
}