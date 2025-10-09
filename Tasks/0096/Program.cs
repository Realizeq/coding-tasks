using System;

class Program
{
    static void Main()
    {
        int n;

        while (true)
        {
            Console.Write("Введите число n (100 < n < 999): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out n) && n > 100 && n < 999)
            {
                break;
            }
            else
            {
                Console.WriteLine("Введите число от 101 до 998.");
            }
        }

        int a = n / 100;
        int b = (n / 10) % 10;
        int c = n % 10;

        int x = a * 100 + b * 10 + c;

        Console.WriteLine($"Исходное число x: {x}");
    }
}