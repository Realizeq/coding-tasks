using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите k (1-252): ");
        int k = int.Parse(Console.ReadLine());

        int digit;

        if (k <= 100)
        {
            int number = 50 + (k - 1) / 2;
            if (k % 2 == 1)
            {
                digit = number / 10;
            }
            else
            {
                digit = number % 10;
            }
        }
        else if (k <= 250)
        {
            int position = k - 100;
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
        else
        {
            if (k == 251)
                digit = 1;
            else if (k == 252)
                digit = 5;
            else
                digit = 0;
        }

        Console.WriteLine($"k-я цифра: {digit}");
    }
}