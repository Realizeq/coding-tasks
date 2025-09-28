using System;
class program
{
    static void Main()
    {
        Console.WriteLine("Блок а)"); // Блок а)

        Console.Write("Введите значение для - x: "); // Ввод значений x и y
        float x = Convert.ToSingle(Console.ReadLine());
        Console.Write("Введите значение для - y: ");
        float y = Convert.ToSingle(Console.ReadLine());

        // Разделение функции для вычисления
        float a_1 = 2 * x * x * x; // 2x^3
        float a_2 = 3.44f * x * y; // 3,44xy
        float a_3 = 2.3f * x * x; // 2,3x^2
        float a_4 = 7.1f * y; // 7,1y
        float z = a_1 - a_2 + a_3 - a_4 + 2; // Собираем функцию по частям

        Console.WriteLine($"\nПри x = {x} и y = {y}"); // Вывод функции блока а)
        Console.WriteLine($"Значение функции z = {z:f2}");

        Console.WriteLine(); // Разделение блоков

        Console.WriteLine("Блок б)"); // Блок б)

        Console.Write("Введите значение для - a: "); // Ввод значений для a и b
        float a = Convert.ToSingle(Console.ReadLine());
        Console.Write("Введите значение для - b: ");
        float b = Convert.ToSingle(Console.ReadLine());

        // Разделение функции для вычисления
        float sum_ab = a + b;
        float b_1 = 3.14f * sum_ab * sum_ab * sum_ab; // 3,14(a + b)^3
        float b_2 = 2.75f * b * b; // 2,75b^2
        float b_3 = 12.7f * a; // 12,7a
        float x1 = b_1 + b_2 - b_3 - 4.1f; // Собираем функцию по частям

        Console.WriteLine($"\nПри a = {a} и b = {b}");
        Console.WriteLine($"Значение функции x = {x1:f2}");
    }
}