using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а) X % 2 != 0 и Y % 2 != 0");
        Console.WriteLine("б) (X < 20) != (Y < 20)");
        Console.WriteLine("в) X == 0 или Y == 0");
        Console.WriteLine("г) X < 0 и Y < 0 и Z < 0");
        Console.WriteLine("д) (X % 5 == 0 && Y % 5 != 0 && Z % 5 != 0) || (X % 5 != 0 && Y % 5 == 0 && Z % 5 != 0) || (X % 5 != 0 && Y % 5 != 0 && Z % 5 == 0)");
        Console.WriteLine("е) X > 100 или Y > 100 или Z > 100");
    }
}