using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите двузначное число: ");
        int number = int.Parse(Console.ReadLine());

        int digit1 = number / 10;
        int digit2 = number % 10;

        if (digit1 == 4 || digit1 == 7 || digit2 == 4 || digit2 == 7)
        {
            Console.WriteLine("а) В числе есть цифра 4 или 7");
        }
        else
        {
            Console.WriteLine("а) В числе нет цифр 4 и 7");
        }

        if (digit1 == 3 || digit1 == 6 || digit1 == 9 || digit2 == 3 || digit2 == 6 || digit2 == 9)
        {
            Console.WriteLine("б) В числе есть цифра 3, 6 или 9");
        }
        else
        {
            Console.WriteLine("б) В числе нет цифр 3, 6 и 9");
        }
    }
}