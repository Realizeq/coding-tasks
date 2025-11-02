using System;
class Program
{
    static void Main()
    {
        double sum = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"введите число a{i}: ");
            double a = double.Parse(Console.ReadLine());
            sum += a;
        }

        if (sum > 100.78) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}