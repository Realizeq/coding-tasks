using System;
class program
{
    static void Main()
    {
        // Ввод длины и высоты
        Console.WriteLine("Введите длины основания:");
        Console.Write("a) ");
        float a = Convert.ToSingle(Console.ReadLine());
        Console.Write("b) ");
        float b = Convert.ToSingle(Console.ReadLine());
        Console.Write("Введите высоту h: ");
        float h = Convert.ToSingle(Console.ReadLine());

        // Вычисление боковой стороны
        float cDiff = MathF.Abs(a - b) / 2f;
        float cSide = MathF.Sqrt(h * h + cDiff * cDiff);

        // Вычисление периметра
        float P = a + b + 2 * cSide;

        // Вывод периметра
        Console.WriteLine($"Периметр равен - {P}");
    }
}