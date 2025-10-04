using System;
class program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int sum = a + b;
        int difference = a - b;
        int product = a * b;
        float division = (float)a / b;
        float average = (float)(a + b) / 2;

        Console.WriteLine($"{a}+{b}={sum}, {a}-{b}={difference}, {a}*{b}={product}, {a}/{b}={division}, ({a}+{b})/2={average}");
    }
}