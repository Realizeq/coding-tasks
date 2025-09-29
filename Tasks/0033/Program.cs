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

        // Вычисляем гипотенузу
        float c = MathF.Sqrt(a * a + b * b);
        // Вычисляем периметр
        float P = a + b + c;

        // Вывод периметра
        Console.WriteLine($"Гипотенуза треугольника равна {c}, соответственно периметр равен - {P}");
    }
}