using System;
class Program
{
    static void Main()
    {
        float x = 3.0f;
        float a = 2.0f;
        float b = 3.0f;
        float c = 1.0f;
        int m = 2;
        int n = 3;

        float res_a = -1 / (x * x);
        float res_b = a / (b * c);
        float res_v = (a / b) * c;
        float res_g = (a + b) / 2;
        float res_d = 5.45f * (a + 2 * b) / (2 - b);
        float res_e = (-b + (float)Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        float res_zh = (-b + 1 / a) / 2;
        float res_z = 1 / (1 + (a + b) / 2);
        float res_i = 1 / (1 + 1 / (2 + 1 / (2 + 5.0f / 5)));
        float res_y = (float)Math.Pow(Math.Pow(2, m), n);

        Console.WriteLine($"а) -1/x^2 = {res_a}");
        Console.WriteLine($"б) a/(b*c) = {res_b}");
        Console.WriteLine($"в) (a/b)*c = {res_v}");
        Console.WriteLine($"г) (a+b)/2 = {res_g}");
        Console.WriteLine($"д) 5,45*(a+2b)/(2-b) = {res_d}");
        Console.WriteLine($"е) (-b+√(b²-4ac))/(2a) = {res_e}");
        Console.WriteLine($"ж) (-b+1/a)/2 = {res_zh}");
        Console.WriteLine($"з) 1/(1+(a+b)/2) = {res_z}");
        Console.WriteLine($"и) 1/(1+1/(2+1/(2+5/5))) = {res_i}");
        Console.WriteLine($"й) 2^(m^n) = {res_y}");
    }
}