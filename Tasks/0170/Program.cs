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

        float discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            Console.WriteLine("Уравнение имеет два различных корня");
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("Уравнение имеет один корень");
        }
        else
        {
            Console.WriteLine("Уравнение не имеет действительных корней");
        }
    }
}