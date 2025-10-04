using System;
class program
{
    static void Main()
    {
        int a = 543;
        int b = 130;

        int boxCount = a / b;

        Console.WriteLine($"Можно отрезать {boxCount} квадратов со стороной {b} мм");
    }
}