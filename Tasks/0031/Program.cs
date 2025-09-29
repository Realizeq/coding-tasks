using System;
class program
{
    static void Main()
    {
        // Ввод катетов
        Console.Write("Введите катет a: ");
        float a = Convert.ToSingle(Console.ReadLine());
        Console.Write("Введите катет b: ");
        float b = Convert.ToSingle(Console.ReadLine());

        // Вычисление гипотенузы
        float c = MathF.Sqrt(a * a + b * b);

        // Вывод гипотенузы
        Console.WriteLine($"Треугольник с катетами {a} и {b}, имеет гипотенузу - {c}");
    }
}