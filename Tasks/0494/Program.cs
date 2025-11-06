using System;
class Program
{
    static void Main()
    {
        int count = 0;

        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"число {i}: ");
            double num = double.Parse(Console.ReadLine());

            if (num >= 0) break;
            count++;
        }

        Console.WriteLine($"отрицательных чисел в начале: {count}");
    }
}