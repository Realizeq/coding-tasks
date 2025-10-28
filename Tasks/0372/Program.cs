using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int n = int.Parse(Console.ReadLine());

        int divisor = 2;
        while (n % divisor != 0)
        {
            divisor++;
        }

        Console.WriteLine($"{divisor}");
    }
}