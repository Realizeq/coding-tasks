using System;
class program
{
    static void Main()
    {
        // Ввод двух целых чисел
        Console.WriteLine("Введите два целых числа по очереди:");
        Console.Write("1) ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("2) ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Вычесление среднего арифметического и геометрического
        float arMean = (num1 + num2) / 2f;
        float geMean = MathF.Sqrt(num1 * num2);

        // Вывод результатов
        Console.WriteLine($"Среднее арифметическое - {arMean}");
        Console.WriteLine($"Среднее геометрическое - {geMean:f2}");
    }
}