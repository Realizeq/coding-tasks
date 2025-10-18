using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Введите c: ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Введите d: ");
        int d = int.Parse(Console.ReadLine());

        // а) Ладья
        if (a == c || b == d)
        {
            Console.WriteLine("а) Ладья угрожает полю");
        }
        else
        {
            Console.WriteLine("а) Ладья не угрожает полю");
        }

        // б) Слон
        if (Math.Abs(a - c) == Math.Abs(b - d))
        {
            Console.WriteLine("б) Слон угрожает полю");
        }
        else
        {
            Console.WriteLine("б) Слон не угрожает полю");
        }

        // в) Король
        if (Math.Abs(a - c) <= 1 && Math.Abs(b - d) <= 1)
        {
            Console.WriteLine("в) Король может попасть на поле");
        }
        else
        {
            Console.WriteLine("в) Король не может попасть на поле");
        }

        // г) Ферзь
        if (a == c || b == d || Math.Abs(a - c) == Math.Abs(b - d))
        {
            Console.WriteLine("г) Ферзь угрожает полю");
        }
        else
        {
            Console.WriteLine("г) Ферзь не угрожает полю");
        }

        // д) Белая пешка
        bool whiteNormal = (a == c && d == b + 1);
        bool whiteCapture = (Math.Abs(a - c) == 1 && d == b + 1);

        if (whiteNormal)
        {
            Console.WriteLine("д) Белая пешка может сделать обычный ход");
        }
        else if (whiteCapture)
        {
            Console.WriteLine("д) Белая пешка может бить фигуру");
        }
        else
        {
            Console.WriteLine("д) Белая пешка не может сделать ход");
        }

        // е) Черная пешка
        bool blackNormal = (a == c && d == b - 1);
        bool blackCapture = (Math.Abs(a - c) == 1 && d == b - 1);

        if (blackNormal)
        {
            Console.WriteLine("е) Черная пешка может сделать обычный ход");
        }
        else if (blackCapture)
        {
            Console.WriteLine("е) Черная пешка может бить фигуру");
        }
        else
        {
            Console.WriteLine("е) Черная пешка не может сделать ход");
        }

        // ж) Конь
        int dx = Math.Abs(a - c);
        int dy = Math.Abs(b - d);

        if ((dx == 1 && dy == 2) || (dx == 2 && dy == 1))
        {
            Console.WriteLine("ж) Конь угрожает полю");
        }
        else
        {
            Console.WriteLine("ж) Конь не угрожает полю");
        }
    }
}