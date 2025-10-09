using System;

class Program
{
    static void Main()
    {
        int n;

        while (true)
        {
            Console.Write("Введите число n (10 < n < 999): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out n) && n >= 10 && n <= 999)
            {
                // десятки не равные нулю
                int tens = (n / 10) % 10;
                if (tens != 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Число десятков не должно быть равно нулю.");
                }
            }
            else
            {
                Console.WriteLine("Введите число от 10 до 999.");
            }
        }

        int firstDigit = n / 100;
        int secondDigit = (n / 10) % 10;
        int thirdDigit = n % 10;

        int x = secondDigit * 100 + firstDigit * 10 + thirdDigit;

        Console.WriteLine($"Исходное число x: {x}");
    }
}