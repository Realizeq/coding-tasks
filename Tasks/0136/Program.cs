using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите двузначное число: ");
        int number = int.Parse(Console.ReadLine());

        int firstDigit = number / 10;
        int secondDigit = number % 10;

        int sumDigits = firstDigit + secondDigit;

        bool isSumTwoDigit = sumDigits >= 10 && sumDigits <= 99;
        bool isSumGreater = sumDigits > number;

        Console.WriteLine($"а) Сумма цифр является двузначным числом - {isSumTwoDigit}");
        Console.WriteLine($"б) Сумма цифр больше самого числа - {isSumGreater}");
    }
}