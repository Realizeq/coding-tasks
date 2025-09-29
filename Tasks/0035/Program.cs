using System;
class program
{
    static void Main()
    {
        // Ввод данных
        Console.WriteLine("Вычисление значения первой функции z");
        Console.WriteLine("Введите значения x и y:");
        Console.Write("x) ");
        float x = Convert.ToSingle(Console.ReadLine());
        Console.Write("y) ");
        float y = Convert.ToSingle(Console.ReadLine());

        // Вычисление первой функции z
        float zNum = x + (2f + y) / (x * x);
        float iDen = y + 1f / MathF.Sqrt(x * x + 10f);
        float zDen = MathF.Pow(iDen, 1f / 3f);
        float z = zNum / zDen;

        // Вычисление второй функции q
        float q = 7.25f * MathF.Sin(x) - MathF.Abs(y);

        // Вывод первой функции z
        Console.WriteLine($"z = {z:f2}");
        Console.WriteLine($"q = {q:f2}");
    }
}