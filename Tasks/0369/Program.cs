using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число > 9: ");
        int n = int.Parse(Console.ReadLine());

        int temp = n;
        int divisor = 1;
        while (temp >= 10)
        {
            divisor *= 10;
            temp /= 10;
        }

        int secondDigit = (n / (divisor / 10)) % 10;

        Console.WriteLine($"{secondDigit}");
    }
}