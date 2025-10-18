using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите четырехзначное число: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Введите любую цифру: ");
        int b = int.Parse(Console.ReadLine());

        int digit1 = number / 1000;
        int digit2 = (number / 100) % 10;
        int digit3 = (number / 10) % 10;
        int digit4 = number % 10;

        if (digit1 == 4 || digit2 == 4 || digit3 == 4 || digit4 == 4)
        {
            Console.WriteLine("а) В числе есть цифра 4");
        }
        else
        {
            Console.WriteLine("а) В числе нет цифры 4");
        }

        if (digit1 == b || digit2 == b || digit3 == b || digit4 == b)
        {
            Console.WriteLine($"б) В числе есть цифра {b}");
        }
        else
        {
            Console.WriteLine($"б) В числе нет цифры {b}");
        }
    }
}