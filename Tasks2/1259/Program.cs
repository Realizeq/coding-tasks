using System;
class Program
{
    static void Main()
    {
        float x = 2.5f;
        float y = 3.1f;
        float a = 1.8f;
        float b = 2.2f;
        float alpha = 0.5f;
        float beta = 0.7f;
        int n = -5;

        float res_a = 2 * x;
        float res_b = (float)Math.Sin(x);
        float res_v = a * a;
        float res_g = (float)Math.Sqrt(x);
        float res_d = Math.Abs(n);
        float res_e = 5 * (float)Math.Cos(y);
        float res_zh = 9.5f * a * a;
        float res_z = 3 * (float)Math.Sqrt(x);
        float res_i = (float)(Math.Sin(alpha) * Math.Cos(beta) + Math.Cos(alpha) * Math.Sin(beta));
        float res_k = a * (float)Math.Sqrt(2 * b);
        float res_l = 4 * (float)Math.Sin(2 * alpha) * (float)Math.Cos(beta);
        float res_m = -5 * (float)Math.Sqrt(x + (float)Math.Sqrt(y));

        Console.WriteLine($"а) 2x = {res_a}");
        Console.WriteLine($"б) sin x = {res_b}");
        Console.WriteLine($"в) a^2 = {res_v}");
        Console.WriteLine($"г) √x = {res_g}");
        Console.WriteLine($"д) |n| = {res_d}");
        Console.WriteLine($"е) 5 cos y = {res_e}");
        Console.WriteLine($"ж) 9,5a^2 = {res_zh}");
        Console.WriteLine($"з) 3√x = {res_z}");
        Console.WriteLine($"и) sinα cosβ + cosα sinβ = {res_i}");
        Console.WriteLine($"к) a√(2b) = {res_k}");
        Console.WriteLine($"л) 4 sin 2α cos β = {res_l}");
        Console.WriteLine($"м) -5√(x+√y) = {res_m}");
    }
}