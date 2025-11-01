using System;
class Program
{
    static void Main()
    {
        int sum = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"введите число a{i}: ");
            int a = int.Parse(Console.ReadLine());
            sum += a;
        }

        Console.WriteLine($"сумма чисел: {sum}");
    }
}