using System;
class Program
{
    static void Main()
    {
        double sum = 0;

        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"a{i}: ");
            double a = double.Parse(Console.ReadLine());
            if (a > 10.75)
            {
                sum += a;
            }
        }

        Console.WriteLine($"сумма чисел больше 10.75: {sum}");
    }
}