using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите четырехзначное число: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int a = int.Parse(Console.ReadLine());

        int digit1 = number / 1000;
        int digit2 = (number / 100) % 10;
        int digit3 = (number / 10) % 10;
        int digit4 = number % 10;

        Console.Write("а) ");
        if (digit1 + digit2 == digit3 + digit4)
            Console.WriteLine("да");
        else
            Console.WriteLine("нет");

        Console.Write("б) ");
        int sum = digit1 + digit2 + digit3 + digit4;
        if (sum % 3 == 0)
            Console.WriteLine("да");
        else
            Console.WriteLine("нет");

        Console.Write("в) ");
        int product = digit1 * digit2 * digit3 * digit4;
        if (product % 4 == 0)
            Console.WriteLine("да");
        else
            Console.WriteLine("нет");

        Console.Write("г) ");
        if (product % a == 0)
            Console.WriteLine("да");
        else
            Console.WriteLine("нет");
    }
}