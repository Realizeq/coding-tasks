using System;
class Program
{
    static void Main()
    {
        int a = 4;
        int b = 6;

        int dlina = 0;
        int x = 1;
        int y = 1;

        while (a > 0 && b > 0)
        {
            dlina += a + b - 1;
            a -= 2;
            b -= 2;
        }

        Console.WriteLine($"длина ограждения: {dlina}");
    }
}