using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите координату x1: ");
        float x1 = float.Parse(Console.ReadLine());

        Console.Write("Введите координату y1: ");
        float y1 = float.Parse(Console.ReadLine());

        Console.Write("Введите координату x2: ");
        float x2 = float.Parse(Console.ReadLine());

        Console.Write("Введите координату y2: ");
        float y2 = float.Parse(Console.ReadLine());

        if (x1 > 2 && y1 > 2)
        {
            Console.WriteLine("а) Точка попадает в область");
        }
        else
        {
            Console.WriteLine("а) Точка не попадает в область");
        }

        if (x2 < -2 && y2 < -4)
        {
            Console.WriteLine("б) Точка попадает в область");
        }
        else
        {
            Console.WriteLine("б) Точка не попадает в область");
        }    
    }
}