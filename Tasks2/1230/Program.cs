using System;
class Program
{
    static float Drob(float verh, float niz)
    {
        return verh / niz;
    }

    static void Main()
    {
        //а
        float ya1 = Drob(2 + (float)Math.Sin(2), (float)Math.Sin(5) + 5);
        float ya2 = Drob(6 + (float)Math.Sin(6), (float)Math.Sin(3) + 3);
        float ya3 = Drob(1 + (float)Math.Sin(1), (float)Math.Sin(4) + 4);
        float ya = ya1 + ya2 + ya3;

        //б
        float yb1 = Drob(1 + (float)Math.Sin(4), 4 + (float)Math.Sin(1));
        float yb2 = Drob(7 + (float)Math.Sin(5), 5 + (float)Math.Sin(7));
        float yb3 = Drob(3 + (float)Math.Sin(2), 2 + (float)Math.Sin(3));
        float yb = yb1 + yb2 + yb3;

        Console.WriteLine($"a) y = {ya}");
        Console.WriteLine($"б) y = {yb}");
    }
}