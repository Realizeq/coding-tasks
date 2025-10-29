using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        int maxDigit = 0;
        int minDigit = 9;
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
                maxPosFromStart = totalDigits + 1; // от начала
            }

            // мин
            if (digit < minDigit)
            {
                minDigit = digit;
                minPosFromStart = totalDigits + 1;
            }

            temp /= 10;
            totalDigits++;
        }

        maxPosFromStart = totalDigits - maxPosFromStart + 1;
        minPosFromStart = totalDigits - minPosFromStart + 1;

        if (maxPosFromStart < minPosFromStart)
        {
            Console.WriteLine("Максимальная");
        }
        else
        {
            Console.WriteLine("Минимальная");
        }
    }
}