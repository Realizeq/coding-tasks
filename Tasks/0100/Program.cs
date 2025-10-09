using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите цифру десятков первого числа: ");
        int a2 = int.Parse(Console.ReadLine());

        Console.Write("Введите цифру единиц первого числа: ");
        int a1 = int.Parse(Console.ReadLine());

        Console.Write("Введите цифру десятков второго числа: ");
        int b2 = int.Parse(Console.ReadLine());

        Console.Write("Введите цифру единиц второго числа: ");
        int b1 = int.Parse(Console.ReadLine());

        int sumUnits = a1 + b1;
        int resultUnits = sumUnits % 10;
        int carry = sumUnits / 10;

        int sumTens = a2 + b2 + carry;
        int resultTens = sumTens % 10;

        Console.WriteLine($"Цифры результата: {resultTens}, {resultUnits}");
    }
}