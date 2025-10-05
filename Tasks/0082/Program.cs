using System;
class program
{
    static void Main()
    {
        Console.Write("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        int a = number / 100;
        int b = (number / 10) % 10; 
        int c = number % 10;

        int num1 = a * 100 + b * 10 + c;
        int num2 = a * 100 + c * 10 + b;
        int num3 = b * 100 + a * 10 + c;
        int num4 = b * 100 + c * 10 + a;
        int num5 = c * 100 + a * 10 + b;
        int num6 = c * 100 + b * 10 + a;

        Console.WriteLine($"Числа после перестановок цифр: {num1}, {num2}, {num3}, {num4}, {num5}, {num6}");
    }
}