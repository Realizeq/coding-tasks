using System;
class program
{
    static void Main()
    {
        float a;
        float b;
        
        // Проверка коэффицента a)
        while (true)
        {
            Console.Write("Введите коэффицент a: ");
            if (float.TryParse(Console.ReadLine(), out a))
                break;
            Console.WriteLine("Введено не число.");
        }

        // Проверка коэффицента b)
        while (true)
        {
            Console.Write("Введите коэффицент b: ");
            if (float.TryParse(Console.ReadLine(), out b))
                break;
            Console.WriteLine("Введено не число.");
        }

        // Вывод заданного уравнения
        Console.WriteLine($"\nЗадано линейное уравнение: {a}x + {b} = 0");

        // Решение уравнения
        // Проверка существования решений
        if (a == 0)
        {
            if (b == 0)
                Console.WriteLine("Бесконечное число решений.");
            else
                Console.WriteLine("Нет решений.");
        }

        else
        {
            float x = -b / a;
            Console.WriteLine($"Ответ: x = {x:f2}");
        }
    }
}