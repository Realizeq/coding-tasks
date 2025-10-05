using System;
class program
{
    static void Main()
    {
        int result = 417;

        int lastDigit = result / 100;
        int firstDigit = (result / 10) % 10;
        int secondDigit = result % 10;

        int x = firstDigit * 100 + secondDigit * 10 + lastDigit;

        Console.WriteLine($"Исходное число x: {x}");
    }
}