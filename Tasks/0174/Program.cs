using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите ребро a кирпича: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Введите ребро b кирпича: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Введите ребро c кирпича: ");
        float c = float.Parse(Console.ReadLine());

        Console.Write("Введите сторону x отверстия: ");
        float x = float.Parse(Console.ReadLine());

        Console.Write("Введите сторону y отверстия: ");
        float y = float.Parse(Console.ReadLine());

        if ((a <= x && b <= y) || (a <= y && b <= x) ||
            (a <= x && c <= y) || (a <= y && c <= x) ||
            (b <= x && c <= y) || (b <= y && c <= x))
        {
            Console.WriteLine("Кирпич пройдет в отверстие");
        }
        else
        {
            Console.WriteLine("Кирпич не пройдет в отверстие");
        }
    }
}