using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите возраст (1-99): ");
        int n = int.Parse(Console.ReadLine());

        if (n >= 11 && n <= 19)
        {
            Console.WriteLine($"мне {n} лет");
        }
        else
        {
            int lastDigit = n % 10;

            if (lastDigit == 1)
            {
                Console.WriteLine($"мне {n} год");
            }
            else if (lastDigit >= 2 && lastDigit <= 4)
            {
                Console.WriteLine($"мне {n} года");
            }
            else
            {
                Console.WriteLine($"мне {n} лет");
            }
        }
    }
}