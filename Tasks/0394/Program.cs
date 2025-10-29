using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        int maxOdd = 0;

        int minDigit = 9;
        int minPosFromStart = 0;
        int totalDigits = 0;

        int countTemp = number;
        while (countTemp > 0)
        {
            totalDigits++;
            countTemp /= 10;
        }

        int temp = number;
        int positionFromStart = totalDigits;

        while (temp > 0)
        {
            int digit = temp % 10;

            if (digit % 2 != 0 && digit > maxOdd)
            {
                maxOdd = digit;
            }

            if (digit <= minDigit)
            {
                minDigit = digit;
                minPosFromStart = positionFromStart;
            }

            temp /= 10;
            positionFromStart--;
        }

        Console.WriteLine($"а) {maxOdd}");
        Console.WriteLine($"б) {minPosFromStart}");
    }
}