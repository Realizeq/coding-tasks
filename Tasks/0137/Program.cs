using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите двузначное число: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int a = int.Parse(Console.ReadLine());

        int firstDigit = number / 10;
        int secondDigit = number % 10;

        int sumDigits = firstDigit + secondDigit;

        bool divisibleBy3 = sumDigits % 3 == 0;
        bool divisibleByA = sumDigits % a == 0;

        Console.WriteLine($"а) Сумма цифр кратна трем - {divisibleBy3}");
        Console.WriteLine($"б) Сумма цифр кратна второму числу - {divisibleByA}");
    }
}