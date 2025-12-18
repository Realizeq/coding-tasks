using System;
class Program
{
    static float Dlina(float x1, float y1, float x2, float y2)
    {
        float dx = x2 - x1;
        float dy = y2 - y1;
        return (float)Math.Sqrt(dx * dx + dy * dy);
    }

    static void Main()
    {
        Console.Write("Введите x1: ");
        float x1 = float.Parse(Console.ReadLine());
        Console.Write("Введите y1: ");
        float y1 = float.Parse(Console.ReadLine());

        Console.Write("Введите x2: ");
        float x2 = float.Parse(Console.ReadLine());
        Console.Write("Введите y2: ");
        float y2 = float.Parse(Console.ReadLine());

        Console.Write("Введите x3: ");
        float x3 = float.Parse(Console.ReadLine());
        Console.Write("Введите y3: ");
        float y3 = float.Parse(Console.ReadLine());

        float a = Dlina(x1, y1, x2, y2);
        float b = Dlina(x2, y2, x3, y3);
        float c = Dlina(x3, y3, x1, y1);

        float perimetr = a + b + c;

        Console.WriteLine($"Периметр = {perimetr}");
    }
}