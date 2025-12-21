using System;
class Program
{
    static void Main()
    {
        int a = 6;
        int s = 0;

        while (a != 2)
        {
            s = s + a;
            a = a - 1;
        }

        Console.WriteLine($"s = {s}");
    }
}