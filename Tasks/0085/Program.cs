using System;
class program
{
    static void Main()
    {
        int n;

        while (true)
        {
            Console.Write("Введите натуральное число (n > 9): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out n) && n > 9)
            {
                break;
            }
            else
            {
                Console.WriteLine("Введите натуральное число больше 9.");
            }
        }

        int units = n % 10;
        int tens = (n / 10) % 10;

        Console.WriteLine($"а) Число единиц: {units}");
        Console.WriteLine($"б) Число десятков: {tens}");
    }
}