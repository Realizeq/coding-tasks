using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        int temp = number;
        int sign = 1;
        int sumA = 0;

        while (temp > 0)
        {
            int digit = temp % 10;
            sumA += sign * digit;
            sign = -sign;
            temp /= 10;
        }

        temp = number;
        sign = 1;
        int sumB = 0;
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
            sumB += sign * digit;
            sign = -sign;
            temp %= divisor;
            divisor /= 10;
        }

        Console.WriteLine($"а) {sumA}");
        Console.WriteLine($"б) {sumB}");
    }
}