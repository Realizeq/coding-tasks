using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите длину стола: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите ширину стола: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Введите длину прямоугольника: ");
        int c = int.Parse(Console.ReadLine());

        Console.Write("Введите ширину прямоугольника: ");
        int d = int.Parse(Console.ReadLine());

        int count1 = (a / c) * (b / d);

        int count2 = (a / d) * (b / c);

        Console.WriteLine($"При размещении длинной стороной вдоль длинной: {count1} прямоугольников");
        Console.WriteLine($"При размещении длинной стороной вдоль короткой: {count2} прямоугольников");

        if (count1 > count2)
        {
            Console.WriteLine("Выгоднее размещать длинной стороной вдоль длинной стороны стола");
        }
        else if (count2 > count1)
        {
            Console.WriteLine("Выгоднее размещать длинной стороной вдоль короткой стороны стола");
        }
        else
        {
            Console.WriteLine("Оба способа размещения дают одинаковое количество");
        }
    }
}