using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите четырехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        int digit1 = number / 1000;
        int digit2 = (number / 100) % 10;
        int digit3 = (number / 10) % 10;
        int digit4 = number % 10;

        if (digit1 == digit4 && digit2 == digit3)
        {
            Console.WriteLine($"Число {number} является симметричным");
        }
        else
        {
            Console.WriteLine($"Число {number} не является симметричным");
        }
    }
}