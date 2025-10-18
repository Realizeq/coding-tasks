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
        Console.Write("Введите e: ");
        int e = int.Parse(Console.ReadLine());
        Console.Write("Введите f: ");
        int f = int.Parse(Console.ReadLine());

        Console.WriteLine("Выберите белую фигуру:");
        Console.WriteLine("1 - ладья");
        Console.WriteLine("2 - ферзь");
        Console.WriteLine("3 - конь");
        Console.WriteLine("4 - слон");
        Console.WriteLine("5 - король");
        Console.Write("Номер: ");
        int whitePiece = int.Parse(Console.ReadLine());

        Console.WriteLine("Выберите черную фигуру:");
        Console.WriteLine("1 - ладья");
        Console.WriteLine("2 - ферзь");
        Console.WriteLine("3 - конь");
        Console.WriteLine("4 - слон");
        Console.Write("Номер: ");
        int blackPiece = int.Parse(Console.ReadLine());

        bool whiteCanMove = false;
        bool blackThreatens = false;

        // Проверка хода белой фигуры
        if (whitePiece == 1) // ладья
        {
            if (a == e || b == f)
            {
                whiteCanMove = true;
            }
        }
        else if (whitePiece == 2) // ферзь
        {
            int diffX = a - e;
            int diffY = b - f;
            if (diffX < 0) diffX = -diffX;
            if (diffY < 0) diffY = -diffY;

            if (a == e || b == f || diffX == diffY)
            {
                whiteCanMove = true;
            }
        }
        else if (whitePiece == 3) // конь
        {
            int diffX = a - e;
            int diffY = b - f;
            if (diffX < 0) diffX = -diffX;
            if (diffY < 0) diffY = -diffY;

            if ((diffX == 1 && diffY == 2) || (diffX == 2 && diffY == 1))
            {
                whiteCanMove = true;
            }
        }
        else if (whitePiece == 4) // слон
        {
            int diffX = a - e;
            int diffY = b - f;
            if (diffX < 0) diffX = -diffX;
            if (diffY < 0) diffY = -diffY;

            if (diffX == diffY)
            {
                whiteCanMove = true;
            }
        }
        else if (whitePiece == 5) // король
        {
            int diffX = a - e;
            int diffY = b - f;
            if (diffX < 0) diffX = -diffX;
            if (diffY < 0) diffY = -diffY;

            if (diffX <= 1 && diffY <= 1)
            {
                whiteCanMove = true;
            }
        }

        // Проверка угрозы черной фигуры
        if (blackPiece == 1) // ладья
        {
            if (c == e || d == f)
            {
                blackThreatens = true;
            }
        }
        else if (blackPiece == 2) // ферзь
        {
            int diffX = c - e;
            int diffY = d - f;
            if (diffX < 0) diffX = -diffX;
            if (diffY < 0) diffY = -diffY;

            if (c == e || d == f || diffX == diffY)
            {
                blackThreatens = true;
            }
        }
        else if (blackPiece == 3) // конь
        {
            int diffX = c - e;
            int diffY = d - f;
            if (diffX < 0) diffX = -diffX;
            if (diffY < 0) diffY = -diffY;

            if ((diffX == 1 && diffY == 2) || (diffX == 2 && diffY == 1))
            {
                blackThreatens = true;
            }
        }
        else if (blackPiece == 4) // слон
        {
            int diffX = c - e;
            int diffY = d - f;
            if (diffX < 0) diffX = -diffX;
            if (diffY < 0) diffY = -diffY;

            if (diffX == diffY)
            {
                blackThreatens = true;
            }
        }

        if (whiteCanMove && !blackThreatens)
        {
            Console.WriteLine("Белая фигура может пойти на поле");
        }
        else if (!whiteCanMove)
        {
            Console.WriteLine("Белая фигура не может пойти на это поле");
        }
        else
        {
            Console.WriteLine("Белая фигура попадет под удар");
        }
    }
}