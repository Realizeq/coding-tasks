using System;
class program
{
    static void Main()
    {
        Console.Write("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        int hundreds = number / 100;
        int tens = (number / 10) % 10;
        int units = number % 10;

        Console.WriteLine(hundreds + "," + tens + "," + units);
    }
}