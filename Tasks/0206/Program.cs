using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите k (1-222): ");
        int k = int.Parse(Console.ReadLine());

        int digit;

        if (k <= 9)
        {
            digit = k;
        }
        else if (k <= 189)
        {
            int position = k - 9;
            int number = 10 + (position - 1) / 2;

            if (position % 2 == 1)
            {
                digit = number / 10;
            }
            else
            {
                digit = number % 10;
            }
        }
        else
        {
            int position = k - 189;
            int number = 100 + (position - 1) / 3;
            int digitPosition = position % 3;

            if (digitPosition == 1)
            {
                digit = number / 100;
            }
            else if (digitPosition == 2)
            {
                digit = (number / 10) % 10;
            }
            else
            {
                digit = number % 10;
            }
        }

        Console.WriteLine($"k-я цифра: {digit}");
    }
}