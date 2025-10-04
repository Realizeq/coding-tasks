using System;
class program
{
    static void Main()
    {
        Console.Write("Введите температуру в градусах Цельсия: ");
        float celsius = Convert.ToSingle(Console.ReadLine());

        float fahrenheit = celsius * 1.8f + 32f;
        float kelvin = celsius + 273.15f;

        Console.WriteLine($"Температура по Фаренгейту: {fahrenheit:F2}");
        Console.WriteLine($"Температура по Кельвину: {kelvin:F2}");
    }
}