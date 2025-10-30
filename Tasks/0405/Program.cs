using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        int temp1 = number;
        int minDigit1 = 9;

        while (temp1 > 0)
        {
            int digit = temp1 % 10;
            if (digit < minDigit1) minDigit1 = digit;
            temp1 /= 10;
        }

        int count1 = 0;
        temp1 = number;

        while (temp1 > 0)
        {
            int digit = temp1 % 10;
            if (digit == minDigit1) count1++;
            temp1 /= 10;
        }

        Console.WriteLine($"Способ 1: {count1}");

        int minDigit2 = 9;
        int count2 = 0;

        int temp2 = number;
        while (temp2 > 0)
        {
            int digit = temp2 % 10;

            if (digit < minDigit2)
            {
                minDigit2 = digit;
                count2 = 1;
            }
            else if (digit == minDigit2)
            {
                count2++;
            }

            temp2 /= 10;
        }

        Console.WriteLine($"Способ 2: {count2}");
    }
}