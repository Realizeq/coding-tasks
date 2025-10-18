using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите двузначное число: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Введите любую цифру: ");
        int a = int.Parse(Console.ReadLine());

        int digit1 = number / 10;
        int digit2 = number % 10;

        if (digit1 == 3 || digit2 == 3)
        {
            Console.WriteLine("а) В числе есть цифра 3");
        }
        else
        {
            Console.WriteLine("а) В числе нет цифры 3");
        }

        if (digit1 == a || digit2 == a)
        {
            Console.WriteLine($"б) В числе есть цифра {a}");
        }
        else
        {
            Console.WriteLine($"б) В числе нет цифры {a}");
        }
    }
}