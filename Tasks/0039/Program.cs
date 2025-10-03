using System;
class program
{
    static void Main()
    {
        // Ввод значений двух чисел
        Console.WriteLine("Введите первое число: ");
        float num1 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Введите второе число: ");
        float num2 = Convert.ToSingle(Console.ReadLine());

        // Вычисления модуля чисел
        float abs1 = Math.Abs(num1);
        float abs2 = Math.Abs(num2);

        float arMean = (abs1 + abs2) / 2f;
        float geMean = MathF.Sqrt(abs1 * abs2);

        Console.WriteLine($"Среднее арифметическое двух чисел: {arMean:f2}");
        Console.WriteLine($"Среднее геометрическое двух чисел: {geMean:f2}");
    }
}