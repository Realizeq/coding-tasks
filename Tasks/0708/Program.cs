using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        int a, b, c, d;

        Console.WriteLine("а) Белая пешка обычный ход:");
        do
        {
            a = rand.Next(1, 9);
            b = rand.Next(1, 8);
            c = a;
            d = b + 1;
        }
        while (b >= 8);
        Console.WriteLine($"Пешка на ({a},{b}), поле ({c},{d})");

        Console.WriteLine("Белая пешка взятие:");
        do
        {
            a = rand.Next(1, 8);
            b = rand.Next(1, 8);
            c = a + 1;
            d = b + 1;
        }
        while (a >= 8 || b >= 8);
        Console.WriteLine($"Пешка на ({a},{b}), поле ({c},{d})");

        Console.WriteLine("б) Черная пешка обычный ход:");
        do
        {
            a = rand.Next(1, 9);
            b = rand.Next(2, 9);
            c = a;
            d = b - 1;
        }
        while (b <= 1);
        Console.WriteLine($"Пешка на ({a},{b}), поле ({c},{d})");

        Console.WriteLine("Черная пешка взятие:");
        do
        {
            a = rand.Next(2, 9);
            b = rand.Next(2, 9);
            c = a - 1;
            d = b - 1;
        }
        while (a <= 1 || b <= 1);
        Console.WriteLine($"Пешка на ({a},{b}), поле ({c},{d})");

        Console.WriteLine("в) Конь угрожает полю:");
        do
        {
            a = rand.Next(1, 9);
            b = rand.Next(1, 9);
            c = rand.Next(1, 9);
            d = rand.Next(1, 9);
        }
        while (!((Math.Abs(a - c) == 1 && Math.Abs(b - d) == 2) ||
                (Math.Abs(a - c) == 2 && Math.Abs(b - d) == 1)));
        Console.WriteLine($"Конь на ({a},{b}), поле ({c},{d})");
    }
}