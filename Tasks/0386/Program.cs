using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        int temp = number;
        int firstDigit = 0;

        while (temp > 0)
        {
            firstDigit = temp % 10;
            temp /= 10;
        }

        temp = number;
        int count = 0;

        while (temp > 0)
        {
            int digit = temp % 10;
            if (digit == firstDigit)
            {
                count++;
            }
            temp /= 10;
        }

        Console.WriteLine($"{count}");
    }
}