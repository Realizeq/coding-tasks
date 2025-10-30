using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        int pos2 = -1;
        int pos5 = -1;
        int positionFromStart = 0;
        int totalDigits = 0;

        int countTemp = number;
        while (countTemp > 0)
        {
            totalDigits++;
            countTemp /= 10;
        }

        int temp = number;
        positionFromStart = totalDigits;

        while (temp > 0)
        {
            int digit = temp % 10;

            if (digit == 2 && pos2 == -1)
            {
                pos2 = positionFromStart;
            }

            if (digit == 5 && pos5 == -1)
            {
                pos5 = positionFromStart;
            }

            temp /= 10;
            positionFromStart--;
        }

        if (pos2 != -1 && pos5 != -1)
        {
            if (pos2 < pos5)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("5");
            }
        }
        else
        {
            Console.WriteLine("Нет обеих");
        }
    }
}