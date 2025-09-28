using System;
class program
{
    static void Main()
    {
        Console.Write("Введите радиус окружности: ");
        float r = Convert.ToSingle(Console.ReadLine());

        float d = 2 * r; // Вычисление диаметра через радиус

        Console.WriteLine($"При радиусе {r}, диаметр равен {d}");
    }
}