using System;
class Program
{
    static void Main()
    {
        int k;

        while (true)
        {
            Console.Write("Введите число k (1 <= k <= 180): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out k) && k >= 1 && k <= 180)
            {
                break;
            }
            else
            {
                Console.WriteLine("Введите число от 1 до 180.");
            }
        }

        int pairNumber = (k + 1) / 2;
        int twoDigitNumber = 10 + pairNumber - 1;

        int digit;
        if (k % 2 == 1)
        {
            digit = twoDigitNumber / 10;
        }
        else
        {
            digit = twoDigitNumber % 10;
        }

        Console.WriteLine($"а) Номер пары цифр: {pairNumber}");
        Console.WriteLine($"б) Двузначное число: {twoDigitNumber}");
        Console.WriteLine($"в) {k}-я цифра: {digit}");
    }
}