using System;
class program
{
    static void Main()
    {
        Console.Write("Введите значение для - a: "); // Ввод значения для - a
        float a = Convert.ToSingle(Console.ReadLine());

        if (a + 1 < 0) // Проверка корня
        {
            Console.WriteLine("Отрицательный корень");
            return;
        }

        if (a + 1 == 0) // Проверка деления на ноль
        {
            Console.WriteLine("Деление на ноль");
            return;
        }

        float num = a * a + 10; // Вычисление числителя 
        float den = MathF.Sqrt(a + 1); // Вычисление знаменателя
        float y = num / den; // Вычисление функции

        Console.WriteLine($"При a = {a}, y = {y}");
    }
}