using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число a: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Введите число b: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Введите число c: ");
        float c = float.Parse(Console.ReadLine());

        if (a == b || a == c || b == c)
        {
            Console.WriteLine("Есть хотя бы одна пара равных чисел");
        }
        else
        {
            Console.WriteLine("Нет ни одной пары равных чисел");
        }
    }
}