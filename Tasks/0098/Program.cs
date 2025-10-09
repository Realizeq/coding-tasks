using System;
class Program
{
    static void Main()
    {
        int n;

        while (true)
        {
            Console.Write("Введите число n (1 <= n <= 999): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out n) && n >= 1 && n <= 999)
            {
                int units = n % 10;
                if (units != 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Число единиц не должно быть равно нулю.");
                }
            }
            else
            {
                Console.WriteLine("Введите число от 1 до 999.");
            }
        }

        int a = n / 100;
        int b = (n / 10) % 10;
        int c = n % 10;

        int x = b * 100 + c * 10 + a;

        Console.WriteLine($"Исходное число x: {x}");
    }
}