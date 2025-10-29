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
        int totalDigits = 0;

        int temp = number;
        int positionFromEnd = 0;

        while (temp > 0)
        {
            positionFromEnd++;
            int digit = temp % 10;

            // макс
            if (digit > maxDigit)
            {
                maxDigit = digit;
                maxPosFromEnd = positionFromEnd;
            }

            // мин
            if (digit < minDigit)
            {
                minDigit = digit;
                minPosFromEnd = positionFromEnd;
            }

            temp /= 10;
            totalDigits++;
        }

        maxPosFromStart = totalDigits - maxPosFromEnd + 1;
        minPosFromStart = totalDigits - minPosFromEnd + 1;

        Console.WriteLine($"а) от конца числа:");
        Console.WriteLine($"   максимальная: {maxPosFromEnd}");
        Console.WriteLine($"   минимальная: {minPosFromEnd}");
        Console.WriteLine($"б) от начала числа:");
        Console.WriteLine($"   максимальная: {maxPosFromStart}");
        Console.WriteLine($"   минимальная: {minPosFromStart}");
    }
}