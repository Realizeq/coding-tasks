using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());
        int digit1 = number / 100;
        int digit2 = (number / 10) % 10;
        int digit3 = number % 10;

        Console.Write("а) ");
        if (digit1 == digit2 && digit2 == digit3)
            Console.WriteLine("да");
        else
            Console.WriteLine("нет");

        Console.Write("б) ");
        if (digit1 == digit2 || digit2 == digit3 || digit1 == digit3)
            Console.WriteLine("да");
        else
            Console.WriteLine("нет");
    }
}