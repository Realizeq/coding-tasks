using System;
class Program
{
    static void Main()
    {
        Console.Write("введите натуральное число n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("введите число b: ");
        int b = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"введите число x{i}: ");
            int x = int.Parse(Console.ReadLine());
            sum += x;
        }

        if (sum % b == 0) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}