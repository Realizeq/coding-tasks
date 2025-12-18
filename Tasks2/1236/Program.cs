using System;
class Program
{
    static float PlTr(float x1, float y1, float x2, float y2, float x3, float y3)
    {
        return Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1)) / 2;
    }

    static void Main()
    {
        float[] x = new float[5];
        float[] y = new float[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Введите x{i + 1}: ");
            x[i] = float.Parse(Console.ReadLine());
            Console.Write($"Введите y{i + 1}: ");
            y[i] = float.Parse(Console.ReadLine());
        }

        float s = PlTr(x[0], y[0], x[1], y[1], x[2], y[2]) +
                  PlTr(x[0], y[0], x[2], y[2], x[3], y[3]) +
                  PlTr(x[0], y[0], x[3], y[3], x[4], y[4]);

        Console.WriteLine($"Площадь пятиугольника = {s}");
    }
}