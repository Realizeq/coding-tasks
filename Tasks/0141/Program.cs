using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int a = int.Parse(Console.ReadLine());

        int firstDigit = number / 100;
        int secondDigit = (number / 10) % 10;
        int thirdDigit = number % 10;

        int sumDigits = firstDigit + secondDigit + thirdDigit;
        int productDigits = firstDigit * secondDigit * thirdDigit;

        bool isSumTwoDigit = sumDigits >= 10 && sumDigits <= 99;
        bool isProductThreeDigit = productDigits >= 100 && productDigits <= 999;
        bool isProductGreaterThanA = productDigits > a;
        bool isSumDivisibleBy5 = sumDigits % 5 == 0;
        bool isSumDivisibleByA = sumDigits % a == 0;

        Console.WriteLine($"а) Сумма цифр является двузначным числом - {isSumTwoDigit}");
        Console.WriteLine($"б) Произведение цифр является трехзначным числом - {isProductThreeDigit}");
        Console.WriteLine($"в) Произведение цифр больше второго числа - {isProductGreaterThanA}");
        Console.WriteLine($"г) Сумма цифр кратна пяти - {isSumDivisibleBy5}");
        Console.WriteLine($"д) Сумма цифр кратна второму числу - {isSumDivisibleByA}");
    }
}