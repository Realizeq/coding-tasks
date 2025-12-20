using System;
class Program
{
    static void Main()
    {
        float x1 = 1.5f;
        float x2 = 2.5f;
        float x3 = 0.5f;
        float x = 0.8f;
        float v0 = 10.0f;
        float t = 2.0f;
        float a = 5.0f;
        float b_val = 3.0f;
        float c_val = 1.0f;
        float R = 7.0f;
        float gamma = 6.67e-11f;
        float m1 = 5.0f;
        float m2 = 10.0f;
        float r = 2.0f;

        Console.WriteLine($"а) {Math.Sqrt(x1 * x1 + x2 * x2)}");
        Console.WriteLine($"б) {x1 * x2 + x1 * x3 + x2 * x3}");
        Console.WriteLine($"в) {Math.Sqrt(1 - (float)Math.Pow(Math.Sin(x), 2))}");
        Console.WriteLine($"г) {v0 * t + (a * t * t) / 2}");
        Console.WriteLine($"д) {Math.Sqrt(a * a + b_val * b_val - 2 * a * b_val * (float)Math.Cos(c_val))}");
        Console.WriteLine($"ж) {2 * (float)Math.PI * R}");
        Console.WriteLine($"з) {b_val * b_val - 4 * a * c_val}");
        Console.WriteLine($"и) {gamma * (m1 * m2) / (r * r)}");
        Console.WriteLine($"т) {Math.Abs(1 - Math.Abs(x))}");
    }
}