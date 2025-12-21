using System;
class Program
{
    static void Main()
    {
        float x, y;
        bool res;

        x = 1; y = -1;
        res = x * x + y * y <= 4;
        Console.WriteLine($"а) {res}");

        x = 1; y = 2;
        res = x >= 0 || y * y != 4;
        Console.WriteLine($"б) {res}");

        x = 1; y = 2;
        res = x >= 0 && y * y != 4;
        Console.WriteLine($"в) {res}");

        x = 2; y = 1;
        res = x * y != 0 && y > x;
        Console.WriteLine($"г) {res}");

        x = 2; y = 1;
        res = x * y != 0 || y < x;
        Console.WriteLine($"д) {res}");

        x = 2; y = 1;
        res = !(x * y < 0) && y > x;
        Console.WriteLine($"е) {res}");

        x = 1; y = 2;
        res = !(x * y < 0) || y > x;
        Console.WriteLine($"ж) {res}");
    }
}