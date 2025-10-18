using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите x1 первого прямоугольника: ");
        float x1 = float.Parse(Console.ReadLine());
        Console.Write("Введите y1 первого прямоугольника: ");
        float y1 = float.Parse(Console.ReadLine());
        Console.Write("Введите ширину первого прямоугольника: ");
        float w1 = float.Parse(Console.ReadLine());
        Console.Write("Введите высоту первого прямоугольника: ");
        float h1 = float.Parse(Console.ReadLine());

        Console.Write("Введите x2 второго прямоугольника: ");
        float x2 = float.Parse(Console.ReadLine());
        Console.Write("Введите y2 второго прямоугольника: ");
        float y2 = float.Parse(Console.ReadLine());
        Console.Write("Введите ширину второго прямоугольника: ");
        float w2 = float.Parse(Console.ReadLine());
        Console.Write("Введите высоту второго прямоугольника: ");
        float h2 = float.Parse(Console.ReadLine());

        if (x1 >= x2 && x1 + w1 <= x2 + w2 && y1 >= y2 && y1 + h1 <= y2 + h2)
        {
            Console.WriteLine("а) Все точки первого прямоугольника принадлежат второму");
        }
        else
        {
            Console.WriteLine("а) Не все точки первого прямоугольника принадлежат второму");
        }

        bool firstInSecond = (x1 >= x2 && x1 + w1 <= x2 + w2 && y1 >= y2 && y1 + h1 <= y2 + h2);
        bool secondInFirst = (x2 >= x1 && x2 + w2 <= x1 + w1 && y2 >= y1 && y2 + h2 <= y1 + h1);

        if (firstInSecond)
        {
            Console.WriteLine("б) Первый прямоугольник принадлежит второму");
        }
        else if (secondInFirst)
        {
            Console.WriteLine("б) Второй прямоугольник принадлежит первому");
        }
        else
        {
            Console.WriteLine("б) Ни один прямоугольник не принадлежит другому полностью");
        }

        if (x1 < x2 + w2 && x1 + w1 > x2 && y1 < y2 + h2 && y1 + h1 > y2)
        {
            Console.WriteLine("в) Прямоугольники пересекаются");
        }
        else
        {
            Console.WriteLine("в) Прямоугольники не пересекаются");
        }
    }
}