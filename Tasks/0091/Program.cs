using System;
class program
{
    static void Main()
    {
        int n;

        while (true)
        {
            Console.Write("Введите число n: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out n) && n >= 1 && n <= 999)
            {
                break;
            }
            else
            {
                Console.WriteLine("Введите число от 1 до 999.");
            }
        }

        int a = n % 10;
        int b = n / 10;
        int x = a * 100 + b;

        Console.WriteLine($"Исходное число x: {x}");
    }
}