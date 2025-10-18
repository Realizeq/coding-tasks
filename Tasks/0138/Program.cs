using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        int firstDigit = number / 100;
        int secondDigit = (number / 10) % 10;
        int thirdDigit = number % 10;

        int reversedNumber = thirdDigit * 100 + secondDigit * 10 + firstDigit;

        bool isPalindrome = number == reversedNumber;

        Console.WriteLine($"Число является палиндромом - {isPalindrome}");
    }
}