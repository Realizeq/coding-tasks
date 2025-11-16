using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        int a, b, c, d;

        Console.WriteLine("а) Ладья не угрожает полю:");
        do
        {
            a = rand.Next(1, 9);
            b = rand.Next(1, 9);
            c = rand.Next(1, 9);
            d = rand.Next(1, 9);
        }
        while (a == c || b == d);
        Console.WriteLine($"Ладья на ({a},{b}), поле ({c},{d})");

        Console.WriteLine("б) Слон не угрожает полю:");
        do
        {
            a = rand.Next(1, 9);
            b = rand.Next(1, 9);
            c = rand.Next(1, 9);
            d = rand.Next(1, 9);
        }
        while (Math.Abs(a - c) == Math.Abs(b - d));
        Console.WriteLine($"Слон на ({a},{b}), поле ({c},{d})");

        Console.WriteLine("в) Король может одним ходом:");
        do
        {
            a = rand.Next(1, 9);
            b = rand.Next(1, 9);
            c = rand.Next(1, 9);
            d = rand.Next(1, 9);
        }
        while (Math.Abs(a - c) > 1 || Math.Abs(b - d) > 1 || (a == c && b == d));
        Console.WriteLine($"Король на ({a},{b}), поле ({c},{d})");

        Console.WriteLine("г) Ферзь не угрожает полю:");
        do
        {
            a = rand.Next(1, 9);
            b = rand.Next(1, 9);
            c = rand.Next(1, 9);
            d = rand.Next(1, 9);
        }
        while (a == c || b == d || Math.Abs(a - c) == Math.Abs(b - d));
        Console.WriteLine($"Ферзь на ({a},{b}), поле ({c},{d})");
    }
}