using System;
class program
{
    static void Main()
    {
        int result = 546;

        int b = result / 100;
        int a = (result / 10) % 10;
        int c = result % 10;
        int x = a * 100 + b * 10 + c;

        Console.WriteLine($"Исходное число x: {x}");
    }
}