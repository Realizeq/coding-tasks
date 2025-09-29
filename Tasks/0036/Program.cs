using System;
class program
{
    static void Main()
    {
        // Ввод значений a и b
        Console.Write("Введите значение a: ");
        float a = Convert.ToSingle(Console.ReadLine());
        Console.Write("Введите значение b: ");
        float b = Convert.ToSingle(Console.ReadLine());

        // Вычисление первой функции x
        float xNum = (2f / (a * a + 25f)) + b;
        float xDen = MathF.Sqrt(b + (a + b) / 2f);
        float x = xNum / xDen;

        // Вычисление второй функции y
        float yNum = MathF.Abs(a) + 2f * MathF.Sin(b);
        float yDen = 5.5f * a;
        float y = xNum / xDen;

        // Вывод
        Console.WriteLine($"x = {x:f2}");
        Console.WriteLine($"y = {y:f2}");
    }
}