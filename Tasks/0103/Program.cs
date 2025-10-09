using System;
class Program
{
    static void Main()
    {
        int k;

        while (true)
        {
            Console.Write("Введите число k (1 <= k <= 150): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out k) && k >= 1 && k <= 150)
            {
                break;
            }
            else
            {
                Console.WriteLine("Введите число от 1 до 150.");
            }
        }

        int numberIndex = (k - 1) / 3;
        int threeDigitNumber = 101 + numberIndex;

        int digitPosition = (k - 1) % 3;
        int digit;

        if (digitPosition == 0)
        {
            digit = threeDigitNumber / 100;
        }
        else if (digitPosition == 1)
        {
            digit = (threeDigitNumber / 10) % 10;
        }
        else
        {
            digit = threeDigitNumber % 10;
        }

        Console.WriteLine($"k-я цифра: {digit}");
    }
}