using System;
class Program
{
    static void Main()
    {
        int a = 256;
        int b = 0;

        while (a != 1)
        {
            a = a / 2;
            b = b + a + 1;
        }

        Console.WriteLine($"b = {b}");
    }
}