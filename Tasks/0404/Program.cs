using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        int temp1 = number;
        int maxDigit1 = 0;

        while (temp1 > 0)
        {
            int digit = temp1 % 10;
            if (digit > maxDigit1) maxDigit1 = digit;
            temp1 /= 10;
        }

        int count1 = 0;
        temp1 = number;

        while (temp1 > 0)
        {
            int digit = temp1 % 10;
            if (digit == maxDigit1) count1++;
            temp1 /= 10;
        }

        Console.WriteLine($"Способ 1: {count1}");

        int maxDigit2 = 0;
        int count2 = 0;

        int temp2 = number;
        while (temp2 > 0)
        {
            int digit = temp2 % 10;

            if (digit > maxDigit2)
            {
                maxDigit2 = digit;
                count2 = 1;  // новая максимальная
            }
            else if (digit == maxDigit2)
            {
                count2++;    // такая же
            }

            temp2 /= 10;
        }

        Console.WriteLine($"Способ 2: {count2}");
    }
}