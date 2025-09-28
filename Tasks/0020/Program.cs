using System;
    class program
{
    static void Main()
    {
        Console.WriteLine("Блок а)"); // Блок а)

        Console.Write("Введите значение для - a: "); // Ввод значения для a
        float a = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine();

        float sin3a = MathF.Sin(MathF.Abs(3 * a));// sin|3a|
        float num_a = 2 * a + sin3a; // 2a + sin|3a|
        float fr_a = num_a / 3.56f; // (2a + sin|3a|) / 3.56
        float res_a = MathF.Sqrt(fr_a); // Вывод корня
        Console.WriteLine($"При a = {a}, ответ: {res_a}");

        Console.WriteLine(); // Разделение блоков

        Console.WriteLine("Блок б)"); // Блок б)

        Console.WriteLine("Введите значение для - x: "); // Ввод значения для x
        float x = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine();

        if (x == 0)
        {
            Console.WriteLine("Деление на ноль");
            return;
        }
        if (x + 1 < 0)
        {
            Console.WriteLine("Отрицательный корень");
            return;
        }

        float sqrt1x = MathF.Sqrt(1 + x); // Корень (1 + x)
        float sum32 = 3.2f + sqrt1x; // 3.2 + sqrt(1 + x)
        float abs5x = MathF.Abs(5 * x); // |5x|
        float fr_b = sum32 / abs5x; // (3.2 + sqrt(1 + x)) / |5x|
        float res_b = MathF.Sin(fr_b); // Вывод синуса 
        Console.WriteLine($"При x = {x}, ответ {res_b}");
    }
}