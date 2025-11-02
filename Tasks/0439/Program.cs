using System;
class Program
{
    static void Main()
    {
        int proizvedenie = 1;

        Console.Write("введите количество чисел: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"введите число a{i}: ");
            int a = int.Parse(Console.ReadLine());
            proizvedenie *= a;
        }

        Console.WriteLine($"произведение чисел: {proizvedenie}");
    }
}