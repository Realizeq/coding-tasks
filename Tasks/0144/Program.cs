using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите четырехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        int digit1 = number / 1000;
        int digit2 = (number / 100) % 10;
        int digit3 = (number / 10) % 10;
        int digit4 = number % 10;

        int sumFirstTwo = digit1 + digit2;
        int sumLastTwo = digit3 + digit4;
        bool sumEqual = sumFirstTwo == sumLastTwo;

        int sumAll = digit1 + digit2 + digit3 + digit4;
        bool multipleOfThree = sumAll % 3 == 0;

        int product = digit1 * digit2 * digit3 * digit4;
        bool multipleOfFour = product % 4 == 0;

        Console.Write("Введите число a: ");
        int a = int.Parse(Console.ReadLine());
        bool multipleOfA = product % a == 0;

        Console.WriteLine($"а) Сумма первых двух цифр равна сумме последних двух - {sumEqual}");
        Console.WriteLine($"б) Сумма цифр кратна трем - {multipleOfThree}");
        Console.WriteLine($"в) Произведение цифр кратно четырем - {multipleOfFour}");
        Console.WriteLine($"г) Произведение цифр кратно {a} - {multipleOfA}");
    }
}