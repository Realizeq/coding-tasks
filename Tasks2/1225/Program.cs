using System;
class Program
{
    static void Obmen(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    static void Main()
    {
        int a = 10;
        int b = 20;
        int c = 30;
        int d = 40;

        Console.WriteLine($"До: a = {a}, b = {b}, c = {c}, d = {d}");

        Obmen(ref a, ref b);
        Obmen(ref c, ref d);

        Console.WriteLine($"После: a = {a}, b = {b}, c = {c}, d = {d}");
    }
}