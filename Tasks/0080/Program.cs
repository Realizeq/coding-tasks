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

        int newNumber = tens * 100 + hundreds * 10 + units;

        Console.WriteLine($"Новое: {newNumber}");
    }
}