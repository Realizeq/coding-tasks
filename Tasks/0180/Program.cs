using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите угол альфа в градусах: ");
        float alpha = float.Parse(Console.ReadLine());

        Console.Write("Введите начальную скорость V: ");
        float v0 = float.Parse(Console.ReadLine());

        Console.Write("Введите расстояние до цели R: ");
        float R = float.Parse(Console.ReadLine());

        Console.Write("Введите высоту цели H: ");
        float H = float.Parse(Console.ReadLine());

        Console.Write("Введите высоту цели P: ");
        float P = float.Parse(Console.ReadLine());

        float g = 9.8f;
        float alphaRad = alpha * (float)Math.PI / 180f;

        float t = R / (v0 * (float)Math.Cos(alphaRad));

        float y = v0 * t * (float)Math.Sin(alphaRad) - g * t * t / 2f;

        if (y >= H && y <= H + P)
        {
            Console.WriteLine("Снаряд поразит цель");
        }
        else
        {
            Console.WriteLine("Снаряд не поразит цель");
        }
    }
}