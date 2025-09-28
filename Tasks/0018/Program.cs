using System;
class programm
{
    static void Main()
    {
        Console.WriteLine("Блок а) y = 17x^2 - 6x + 13"); // Блок а)
        
        Console.WriteLine(); // Разделение строк
        
        Console.Write("Введите значение для - x: ");
        float x = Convert.ToSingle(Console.ReadLine());
        float y1 = 17 * x * x - 6 * x + 13;
        Console.WriteLine($"При x = {x}, y = {y1}");
        
        Console.WriteLine(); // Разделение блоков
        
        Console.WriteLine("Блок б) y = 3a^2 + 5a - 21"); // Блок б)

        Console.WriteLine(); // Разделение строк

        Console.Write("Введите значение для - a: ");
        float a = Convert.ToSingle(Console.ReadLine());
        float y2 = 3 * a * a + 5 * a - 21;
        Console.WriteLine($"При a = {a}, y = {y2}");
    }
}