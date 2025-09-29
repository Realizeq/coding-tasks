using System;
class program
{
    static void Main()
    {
        // Ввод количества жителей и площадь государства
        Console.Write("Введите количество жителей: ");
        int pCount = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите площадь государства в км^2: ");
        float s = Convert.ToSingle(Console.ReadLine());

        // Вычисление плотности населения
        float d = pCount / s;

        // Вывод данных
        Console.WriteLine($"Плотность населения составляет - {d:f2} чел/км^2");
    }
}