using System;
class program
{
    static void Main()
    {
        int result = 564;

        int raz = result % 10;
        int dva = result / 10;
        int x = raz * 100 + dva;

        Console.WriteLine($"Исходное число x: {x}");
    }
}