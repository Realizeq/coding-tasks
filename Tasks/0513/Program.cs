using System;
class Program
{
    static void Main()
    {
        int count = 0;

        for (int i = 1; i <= 15; i++)
        {
            Console.Write($"x{i}: ");
            double x = double.Parse(Console.ReadLine());

            if (x <= 33.2) count++;
        }

        if (count % 4 == 0) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}