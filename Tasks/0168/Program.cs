using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите сторону a: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Введите сторону b: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Введите сторону c: ");
        float c = float.Parse(Console.ReadLine());

        if (a == b && b == c)
        {
            Console.WriteLine("а) Треугольник является равносторонним");
        }
        else
        {
            Console.WriteLine("а) Треугольник не является равносторонним");
        }

        if (a == b || a == c || b == c)
        {
            Console.WriteLine("б) Треугольник является равнобедренным");
        }
        else
        {
            Console.WriteLine("б) Треугольник не является равнобедренным");
        }
    }
}