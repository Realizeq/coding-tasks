using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите двузначное число: ");
        int number = int.Parse(Console.ReadLine());

        int firstDigit = number / 10;
        int secondDigit = number % 10;

        int sumCubes = firstDigit * firstDigit * firstDigit +
                      secondDigit * secondDigit * secondDigit;

        bool isEqual = (number * number) == sumCubes;

        Console.WriteLine($"Равен ли квадрат числа сумме кубов - {isEqual}");
    }
}