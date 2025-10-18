using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите цифру десятков a2: ");
        int a2 = int.Parse(Console.ReadLine());

        Console.Write("Введите цифру единиц a1: ");
        int a1 = int.Parse(Console.ReadLine());

        Console.Write("Введите число b: ");
        int b = int.Parse(Console.ReadLine());

        int resultUnits;
        int resultTens;

        if (a1 >= b)
        {
            resultUnits = a1 - b;
            resultTens = a2;
        }
        else
        {
            resultUnits = 10 + a1 - b;
            resultTens = a2 - 1;
        }

        Console.WriteLine($"Цифры разности: {resultTens} (десятки), {resultUnits} (единицы)");
    }
}