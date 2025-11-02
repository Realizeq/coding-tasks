using System;
class Program
{
    static void Main()
    {
        Console.Write("введите натуральное число n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("введите число p: ");
        int p = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"введите число b{i}: ");
            int b = int.Parse(Console.ReadLine());
            sum += b;
        }

        if (sum < p) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}