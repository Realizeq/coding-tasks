using System;
class Program
{
    static void Main()
    {
        double perimetr = 0;

        for (int i = 1; i <= 12; i++)
        {
            Console.Write($"введите длину стороны {i}: ");
            double storona = double.Parse(Console.ReadLine());
            perimetr += storona;
        }

        Console.WriteLine($"периметр 12-угольника: {perimetr}");
    }
}