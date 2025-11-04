using System;
class Program
{
    static void Main()
    {
        int sum = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"a{i}: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                sum += a;
            }
        }

        Console.WriteLine($"сумма четных чисел: {sum}");
    }
}