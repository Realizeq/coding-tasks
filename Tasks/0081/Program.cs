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

        int newNumber = hundreds * 100 + units * 10 + tens;

        Console.WriteLine($"Новое: {newNumber}");
    }
}