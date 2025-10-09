using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите цифру сотен трехзначного числа: ");
        int a3 = int.Parse(Console.ReadLine());

        Console.Write("Введите цифру десятков трехзначного числа: ");
        int a2 = int.Parse(Console.ReadLine());

        Console.Write("Введите цифру единиц трехзначного числа: ");
        int a1 = int.Parse(Console.ReadLine());

        Console.Write("Введите цифру десятков двузначного числа: ");
        int b2 = int.Parse(Console.ReadLine());

        Console.Write("Введите цифру единиц двузначного числа: ");
        int b1 = int.Parse(Console.ReadLine());

        int sumUnits = a1 + b1;
        int resultUnits = sumUnits % 10;
        int carry1 = sumUnits / 10;

        int sumTens = a2 + b2 + carry1;
        int resultTens = sumTens % 10;
        int carry2 = sumTens / 10;

        int resultHundreds = a3 + carry2;

        Console.WriteLine($"Цифры результата: {resultHundreds}, {resultTens}, {resultUnits}");
    }
}