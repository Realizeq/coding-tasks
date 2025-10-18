using System;
class program
{
    static void Main()
    {
        Console.Write("Введите координату x: ");
        float x = float.Parse(Console.ReadLine());
        Console.Write("Введите координату y: ");
        float y = float.Parse(Console.ReadLine());

        if (x > 3 && y > 2)
        {
            Console.WriteLine("Точка попадает в область");
        }
        else
        {
            Console.WriteLine("Точка не попадает в область");
        }
    }
}