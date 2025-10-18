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

        if (digit1 == 2 || digit1 == 7 || digit2 == 2 || digit2 == 7 || digit3 == 2 || digit3 == 7 || digit4 == 2 || digit4 == 7)
        {
            Console.WriteLine("а) В числе есть цифра 2 или 7");
        }
        else
        {
            Console.WriteLine("а) В числе нет цифр 2 и 7");
        }

        if (digit1 == 3 || digit1 == 6 || digit1 == 9 || digit2 == 3 || digit2 == 6 || digit2 == 9 || digit3 == 3 || digit3 == 6 || digit3 == 9 || digit4 == 3 || digit4 == 6 || digit4 == 9)
        {
            Console.WriteLine("б) В числе есть цифра 3, 6 или 9");
        }
        else
        {
            Console.WriteLine("б) В числе нет цифр 3, 6 и 9");
        }
    }
}