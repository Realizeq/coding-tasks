using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите сторону a первого прямоугольника: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Введите сторону b первого прямоугольника: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Введите сторону a второго прямоугольника: ");
        float c = float.Parse(Console.ReadLine());

        Console.Write("Введите сторону b второго прямоугольника: ");
        float d = float.Parse(Console.ReadLine());

        if ((a <= c && b <= d) || (a <= d && b <= c))
        {
            Console.WriteLine("Прямоугольник можно уместить");
        }
        else
        {
            Console.WriteLine("Прямоугольник нельзя уместить");
        }
    }
}