using System;
class Program
{
    static void Main()
    {
        int sum = 0;

        for (int i = 1; i <= 4; i++)
        {
            Console.Write($"введите число a{i}: ");
            int a = int.Parse(Console.ReadLine());
            sum += a;
        }

        if (sum % 2 == 0) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}