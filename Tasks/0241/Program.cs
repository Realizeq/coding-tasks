using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите x: ");
        float x = float.Parse(Console.ReadLine());

        Console.Write("Введите y: ");
        float y = float.Parse(Console.ReadLine());

        int quarter;

        if (x > 0 && y > 0)
        {
            quarter = 1;
        }
        else if (x < 0 && y > 0)
        {
            quarter = 2;
        }
        else if (x < 0 && y < 0)
        {
            quarter = 3;
        }
        else
        {
            quarter = 4;
        }

        Console.WriteLine($"Точка находится в {quarter} четверти");
    }
}