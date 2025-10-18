using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите рост первого человека: ");
        float height1 = float.Parse(Console.ReadLine());

        Console.Write("Введите рост второго человека: ");
        float height2 = float.Parse(Console.ReadLine());

        Console.Write("Введите рост третьего человека: ");
        float height3 = float.Parse(Console.ReadLine());

        if (height1 == height2 && height2 == height3)
        {
            Console.WriteLine("Рост всех трех человек одинаковый");
        }
        else
        {
            Console.WriteLine("Рост трех человек не одинаковый");
        }
    }
}