using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        bool isEven = number % 2 == 0;
        bool endsWith7 = number % 10 == 7;

        Console.WriteLine($"а) Является ли число четным - {isEven}");
        Console.WriteLine($"б) Оканчивается ли оно на 7 - {endsWith7}");
    }
}