using System;
class Program
{
    static bool EstKorni(float a, float b, float c)
    {
        float d = b * b - 4 * a * c;
        return d >= 0;
    }

    static void Main()
    {
        Console.Write("Введите a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Введите c: ");
        float c = float.Parse(Console.ReadLine());

        int schet = 0;

        if (EstKorni(a, b, c)) schet++;
        if (EstKorni(b, a, c)) schet++;
        if (EstKorni(c, a, b)) schet++;

        Console.WriteLine($"Количество уравнений с вещественными корнями: {schet}");
    }
}