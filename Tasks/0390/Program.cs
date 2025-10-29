using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        int maxDigit = 0;
        int minDigit = 9;

        int temp = number;
        while (temp > 0)
        {
            int digit = temp % 10;

            if (digit > maxDigit) maxDigit = digit;
            if (digit < minDigit) minDigit = digit;

            temp /= 10;
        }

        int difference = maxDigit - minDigit;

        if (difference % 2 == 0)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
}