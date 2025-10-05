using System;
class program
{
    static void Main()
    {
        Console.Write("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        int units = number % 10;
        int tens = (number / 10) % 10;
        int hundreds = number / 100;

        int sum = units + tens + hundreds;
        int product = units * tens * hundreds;

        Console.WriteLine("а) Число единиц: " + units);
        Console.WriteLine("б) Число десятков: " + tens);
        Console.WriteLine("в) Сумма цифр: " + sum);
        Console.WriteLine("г) Произведение цифр: " + product);
    }
}