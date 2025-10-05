using System;
class program
{
    static void Main()
    {
        int n;

        while (true)
        {
            Console.Write("Введите натуральное число (n > 99): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out n) && n > 99)
            {
                break;
            }
            else
            {
                Console.WriteLine("Введите натуральное число больше 99.");
            }
        }

        int tens = (n / 10) % 10;
        int hundreds = (n / 100) % 10;

        Console.WriteLine($"а) Число десятков: {tens}");
        Console.WriteLine($"б) Число сотен: {hundreds}");
    }
}