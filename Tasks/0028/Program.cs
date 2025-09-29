using System;
class program
{
    static void Main()
    {
        // Ввод объема и массы тела
        Console.Write("Введите объём тела (см^3): ");
        float V = Convert.ToSingle(Console.ReadLine());
        Console.Write("Введите массу тела (кг): ");
        float m = Convert.ToSingle(Console.ReadLine());

        // Вычисление плотности материала тела
        float p = m / V;

        Console.Write($"Плотность материал тела - {p:F2} г/см^3");
    }
}