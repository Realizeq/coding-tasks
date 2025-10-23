using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Введите степень: ");
        int n = int.Parse(Console.ReadLine());

        float power = 1.0f;

        for (int i = 1; i <= n; i++)
        {
            power *= a;
            if (i >= 2)
            {
                Console.WriteLine($"a^{i} = {power:F2}");
            }
        }
    }
}