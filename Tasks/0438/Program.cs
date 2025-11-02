using System;
class Program
{
    static void Main()
    {
        int sum1 = 0;
        int sum2 = 0;

        Console.WriteLine("баллы первого спортсмена");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"вид спорта {i}: ");
            int ball = int.Parse(Console.ReadLine());
            sum1 += ball;
        }

        Console.WriteLine("баллы второго спортсмена");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"вид спорта {i}: ");
            int ball = int.Parse(Console.ReadLine());
            sum2 += ball;
        }

        Console.WriteLine($"сумма баллов первого: {sum1}");
        Console.WriteLine($"сумма баллов второго: {sum2}");
    }
}