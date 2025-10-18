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

        int square = number * number;
        int sumCubes = firstDigit * firstDigit * firstDigit +
                      secondDigit * secondDigit * secondDigit +
                      thirdDigit * thirdDigit * thirdDigit;

        bool isEqual = square == sumCubes;

        Console.WriteLine($"Квадрат числа равен сумме кубов цифр - {isEqual}");
    }
}