using System;
class Program
{
    static void Main()
    {
        float a, b, c;

        Console.Write("Введите a: ");
        a = float.Parse(Console.ReadLine());

        Console.Write("Введите b: ");
        b = float.Parse(Console.ReadLine());

        Console.Write("Введите c: ");
        c = float.Parse(Console.ReadLine());

        float d = b * b - 4 * a * c;

        string result;

        if (d >= 0)
        {
            result = "имеет корни";
        }
        else
        {
            result = "не имеет корней";
        }

        Console.WriteLine($"Уравнение {result}");
    }
}