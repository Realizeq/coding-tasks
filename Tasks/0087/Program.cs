using System;
class program
{
    static void Main()
    {
        int n;

        while (true)
        {
            Console.Write("Введите натуральное число (n > 999): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out n) && n > 999)
            {
                break;
            }
            else
            {
                Console.WriteLine("Введите натуральное число больше 999.");
            }
        }

        int hundreds = (n / 100) % 10;
        int thousands = n / 1000;

        Console.WriteLine($"а) Число сотен: {hundreds}");
        Console.WriteLine($"б) Число тысяч: {thousands}");
    }
}