using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число > 99: ");
        int n = int.Parse(Console.ReadLine());

        int temp = n;
        int divisor = 1;
        while (temp >= 100)
        {
            divisor *= 10;
            temp /= 10;
        }

        int thirdDigit = (n / (divisor / 100)) % 10;

        Console.WriteLine($"{thirdDigit}");
    }
}