using System;
class Program
{
    static void Main()
    {
        int sum1 = 0;
        int sum2 = 0;

        Console.WriteLine("баллы первого спортсмена:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"вид спорта {i}: ");
            int ball1 = int.Parse(Console.ReadLine());
            sum1 += ball1;
        }

        Console.WriteLine("баллы второго спортсмена:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"вид спорта {i}: ");
            int ball2 = int.Parse(Console.ReadLine());
            sum2 += ball2;
        }

        if (sum1 > sum2) Console.WriteLine("первый");
        else if (sum2 > sum1) Console.WriteLine("второй");
        else Console.WriteLine("одинаково");
    }
}