using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите цифру десятков двузначного числа: ");
        int a2 = int.Parse(Console.ReadLine());

        Console.Write("Введите цифру единиц двузначного числа: ");
        int a1 = int.Parse(Console.ReadLine());

        Console.Write("Введите однозначное число: ");
        int b = int.Parse(Console.ReadLine());

        int sum = a1 + b;
        int resultUnits = sum % 10;
        int resultTens = a2 + sum / 10;

        Console.WriteLine($"Цифры результата: {resultTens}, {resultUnits}");
    }
}