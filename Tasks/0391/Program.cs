using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        int maxDigit = 0;
        int minDigit = 9;
        int maxPosFromEnd = 0;
        int minPosFromEnd = 0;
        int maxPosFromStart = 0;
        int minPosFromStart = 0;

        int temp = number;
        int positionFromEnd = 0;
        int totalDigits = 0;

        int countTemp = number;
        while (countTemp > 0)
        {
            totalDigits++;
            countTemp /= 10;
        }

        temp = number;
        while (temp > 0)
        {
            positionFromEnd++;
            int digit = temp % 10;

            // макс
            if (digit > maxDigit)
            {
                maxDigit = digit;
                maxPosFromEnd = positionFromEnd;
                maxPosFromStart = totalDigits - positionFromEnd + 1;
            }

            // мин
            if (digit < minDigit)
            {
                minDigit = digit;
                minPosFromEnd = positionFromEnd;
                minPosFromStart = totalDigits - positionFromEnd + 1;
            }

            temp /= 10;
        }

        Console.WriteLine($"а) Максимальная цифра:");
        Console.WriteLine($"   от конца: {maxPosFromEnd}");
        Console.WriteLine($"   от начала: {maxPosFromStart}");
        Console.WriteLine($"б) Минимальная цифра:");
        Console.WriteLine($"   от конца: {minPosFromEnd}");
        Console.WriteLine($"   от начала: {minPosFromStart}");
    }
}