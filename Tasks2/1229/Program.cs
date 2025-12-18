using System;
class Program
{
    static float Chast(float verh, float niz)
    {
        return verh / niz;
    }

    static void Main()
    {
        //а
        float a1 = Chast(5 + (float)Math.Sqrt(5), (float)Math.Sqrt(7) + 7);
        float a2 = Chast(12 + (float)Math.Sqrt(12), (float)Math.Sqrt(8) + 8);
        float a3 = Chast(31 + (float)Math.Sqrt(31), (float)Math.Sqrt(2) + 2);
        float xa = a1 + a2 + a3;

        //б
        float b1 = Chast(13 + (float)Math.Sqrt(7), 7 + (float)Math.Sqrt(13));
        float b2 = Chast(15 + (float)Math.Sqrt(12), (float)Math.Sqrt(15) + 12);
        float b3 = Chast((float)Math.Sqrt(21) + 32, (float)Math.Sqrt(32) + 21);
        float xb = b1 + b2 + b3;

        Console.WriteLine($"a) x = {xa}");
        Console.WriteLine($"b) x = {xb}");
    }
}