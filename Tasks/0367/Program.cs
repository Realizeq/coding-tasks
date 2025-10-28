using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        int temp = number;
        int divisor = 1;

        while (temp >= 10)
        {
            divisor *= 10;
            temp /= 10;
        }

        temp = number;
        while (divisor > 0)
        {
            int digit = temp / divisor;
            Console.WriteLine(digit);
            temp %= divisor;
            divisor /= 10;
        }
    }
}