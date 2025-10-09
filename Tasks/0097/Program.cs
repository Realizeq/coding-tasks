using System;
class Program
{
    static void Main()
    {
        int result = 654;

        int a = result / 100;
        int b = (result / 10) % 10;
        int c = result % 10;

        int x = c * 100 + a * 10 + b;

        Console.WriteLine($"Исходное число x: {x}");
    }
}