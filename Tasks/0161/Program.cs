using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Введите любую цифру: ");
        int n = int.Parse(Console.ReadLine());

        int digit1 = number / 100;
        int digit2 = (number / 10) % 10;
        int digit3 = number % 10;

        if (digit1 == 6 || digit2 == 6 || digit3 == 6)
        {
            Console.WriteLine("а) В числе есть цифра 6");
        }
        else
        {
            Console.WriteLine("а) В числе нет цифры 6");
        }

        if (digit1 == n || digit2 == n || digit3 == n)
        {
            Console.WriteLine($"б) В числе есть цифра {n}");
        }
        else
        {
            Console.WriteLine($"б) В числе нет цифры {n}");
        }
    }
}