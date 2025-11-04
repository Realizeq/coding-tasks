using System;
class Program
{
    static void Main()
    {
        double sum = 0;

        for (int i = 1; i <= 15; i++)
        {
            Console.Write($"c{i}: ");
            double c = double.Parse(Console.ReadLine());
            if (i % 2 == 1)
            {
                sum -= c;
            }
        }

        Console.WriteLine($"результат: {sum}");
    }
}