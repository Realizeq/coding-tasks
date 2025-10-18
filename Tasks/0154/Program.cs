using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите координату x: ");
        float x = float.Parse(Console.ReadLine());

        Console.Write("Введите координату y: ");
        float y = float.Parse(Console.ReadLine());

        if (y > 0)
        {
            if (x < -1)
            {
                Console.WriteLine("Точка попадает в область III");
            }
            else if (x > 5)
            {
                Console.WriteLine("Точка попадает в область I");
            }
        }
        else
        {
            Console.WriteLine("Точка не попадает в одну из областей");
        }
    }
}