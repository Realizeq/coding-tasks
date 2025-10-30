using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        int max1 = 0;
        int max2 = -1;

        int min1 = 9;
        int min2 = 10;

        int temp = number;
        while (temp > 0)
        {
            int digit = temp % 10;

            if (digit > max1)
            {
                max2 = max1;
                max1 = digit;
            }
            else if (digit > max2 && digit < max1)
            {
                max2 = digit;
            }

            if (digit < min1)
            {
                min2 = min1;
                min1 = digit;
            }
            else if (digit < min2 && digit > min1)
            {
                min2 = digit;
            }

            temp /= 10;
        }

        Console.WriteLine($"а) Максимальные: {max1} и {max2}");
        Console.WriteLine($"б) Минимальные: {min1} и {min2}");
    }
}