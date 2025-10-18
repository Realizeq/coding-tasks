using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите размер форточки по горизонтали: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Введите размер форточки по вертикали: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Введите диаметр головы: ");
        float d = float.Parse(Console.ReadLine());

        if (d + 2 <= a && d + 2 <= b)
        {
            Console.WriteLine("Голова пролезет в форточку");
        }
        else
        {
            Console.WriteLine("Голова не пролезет в форточку");
        }
    }
}