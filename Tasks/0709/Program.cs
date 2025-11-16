using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        int a, b, c, d, e, f;

        Console.WriteLine("а) Ладья и ладья:");
        do
        {
            a = rand.Next(1, 9);
            b = rand.Next(1, 9);
            c = rand.Next(1, 9);
            d = rand.Next(1, 9);
            e = rand.Next(1, 9);
            f = rand.Next(1, 9);
        }
        while (!((a == e || b == f) &&
                !(c == e || d == f) &&
                !(a == c && b == d) &&
                !(a == e && b == f) &&
                !(c == e && d == f)));
        Console.WriteLine($"Белая ладья: ({a},{b}) на ({e},{f})");
        Console.WriteLine($"Черная ладья: ({c},{d})");

        Console.WriteLine("б) Ладья и ферзь:");
        do
        {
            a = rand.Next(1, 9);
            b = rand.Next(1, 9);
            c = rand.Next(1, 9);
            d = rand.Next(1, 9);
            e = rand.Next(1, 9);
            f = rand.Next(1, 9);
        }
        while (!((a == e || b == f) &&
                !(c == e || d == f || Math.Abs(c - e) == Math.Abs(d - f)) &&
                !(a == c && b == d) &&
                !(a == e && b == f) &&
                !(c == e && d == f)));
        Console.WriteLine($"Белая ладья: ({a},{b}) на ({e},{f})");
        Console.WriteLine($"Черная ферзь: ({c},{d})");

        Console.WriteLine("в) Ладья и конь:");
        do
        {
            a = rand.Next(1, 9);
            b = rand.Next(1, 9);
            c = rand.Next(1, 9);
            d = rand.Next(1, 9);
            e = rand.Next(1, 9);
            f = rand.Next(1, 9);
        }
        while (!((a == e || b == f) &&
                !((Math.Abs(c - e) == 1 && Math.Abs(d - f) == 2) ||
                  (Math.Abs(c - e) == 2 && Math.Abs(d - f) == 1)) &&
                !(a == c && b == d) &&
                !(a == e && b == f) &&
                !(c == e && d == f)));
        Console.WriteLine($"Белая ладья: ({a},{b}) на ({e},{f})");
        Console.WriteLine($"Черный конь: ({c},{d})");

        Console.WriteLine("г) Ладья и слон:");
        do
        {
            a = rand.Next(1, 9);
            b = rand.Next(1, 9);
            c = rand.Next(1, 9);
            d = rand.Next(1, 9);
            e = rand.Next(1, 9);
            f = rand.Next(1, 9);
        }
        while (!((a == e || b == f) &&
                !(Math.Abs(c - e) == Math.Abs(d - f)) &&
                !(a == c && b == d) &&
                !(a == e && b == f) &&
                !(c == e && d == f)));
        Console.WriteLine($"Белая ладья: ({a},{b}) на ({e},{f})");
        Console.WriteLine($"Черный слон: ({c},{d})");
    }
}