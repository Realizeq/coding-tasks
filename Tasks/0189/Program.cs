using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Введите b: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Введите c: ");
        float c = float.Parse(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            else
            {
                Console.WriteLine("Треугольник не прямоугольный");
            }
        }
        else
        {
            Console.WriteLine("Треугольник не существует");
        }
    }
}