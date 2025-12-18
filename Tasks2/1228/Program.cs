using System;
class Program
{
    static float Funct(float a)
    {
        return (float)(Math.Sqrt(a) + a) / 2;
    }

    static void Main()
    {
        float n1 = 6;
        float n2 = 13;
        float n3 = 21;

        float x = Funct(n1) + Funct(n2) + Funct(n3);

        Console.WriteLine($"x = {x}");
    }
}