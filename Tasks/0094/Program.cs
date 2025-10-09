using System;
class Program
{
    static void Main()
    {
        int result = 456;

        int a = result / 100;
        int b = (result / 10) % 10;
        int c = result % 10;

        int x = a * 100 + b * 10 + c;

        Console.WriteLine($"Исходное число x: {x}");
    }
}