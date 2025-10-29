using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        bool has3 = false;
        bool has2 = false;
        bool has5 = false;

        int temp = number;
        while (temp > 0)
        {
            int digit = temp % 10;

            if (digit == 3) has3 = true;
            if (digit == 2) has2 = true;
            if (digit == 5) has5 = true;

            temp /= 10;
        }

        Console.WriteLine($"а) {has3}");

        bool has2and5 = has2 && has5;
        Console.WriteLine($"б) {has2and5}");
    }
}