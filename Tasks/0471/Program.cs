using System;
class Program
{
    static void Main()
    {
        int sum = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"число {i}: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 10 == 0)
            {
                sum += num;
            }
        }

        Console.WriteLine($"сумма чисел оканчивающихся нулем: {sum}");
    }
}