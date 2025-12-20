using System;
class Program
{
    static void Main()
    {
        float a = 4.0f;
        float b = 2.0f;
        float c = 1.0f;
        float d = 3.0f;

        float res_a = a / b / c;
        float res_b = a + b / c;
        float res_v = (a + b) / c;
        float res_g = (float)Math.Pow(a, b) / (c + 2);
        float res_d = a / b * (c - 3) / d;
        float res_e = (a / 3 + b / 2) / (b + c / (2 + b));

        Console.WriteLine($"а) a/b/c = {res_a}");
        Console.WriteLine($"б) a+b/c = {res_b}");
        Console.WriteLine($"в) (a+b)/c = {res_v}");
        Console.WriteLine($"г) a^b/(c+2) = {res_g}");
        Console.WriteLine($"д) a/b*(c-3)/d = {res_d}");
        Console.WriteLine($"е) (a/3+b/2)/(b+c/(2+b)) = {res_e}");
    }
}