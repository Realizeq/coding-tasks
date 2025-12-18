using System;
class Program
{
    static float Gipot(float a, float b)
    {
        return (float)Math.Sqrt(a * a + b * b);
    }

    static void Main()
    {
        Console.Write("Введите AB: ");
        float ab = float.Parse(Console.ReadLine());

        Console.Write("Введите AD: ");
        float ad = float.Parse(Console.ReadLine());

        Console.Write("Введите CD: ");
        float cd = float.Parse(Console.ReadLine());

        float bd = Gipot(ab, ad);
        float bc = Gipot(bd, cd);

        float perimetr = ab + ad + cd + bc;

        Console.WriteLine($"Периметр = {perimetr}");
    }
}