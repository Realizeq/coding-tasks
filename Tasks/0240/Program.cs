using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первую тройку чисел:");
        Console.Write("a1: ");
        float a1 = float.Parse(Console.ReadLine());
        Console.Write("a2: ");
        float a2 = float.Parse(Console.ReadLine());
        Console.Write("a3: ");
        float a3 = float.Parse(Console.ReadLine());

        Console.WriteLine("Введите вторую тройку чисел:");
        Console.Write("b1: ");
        float b1 = float.Parse(Console.ReadLine());
        Console.Write("b2: ");
        float b2 = float.Parse(Console.ReadLine());
        Console.Write("b3: ");
        float b3 = float.Parse(Console.ReadLine());

        float middle1, middle2;

        // среднее арифм для первой тройки
        if (a1 > a2 && a1 < a3 || a1 < a2 && a1 > a3)
        {
            middle1 = a1;
        }
        else if (a2 > a1 && a2 < a3 || a2 < a1 && a2 > a3)
        {
            middle1 = a2;
        }
        else
        {
            middle1 = a3;
        }

        // среднее для второй тройки
        if (b1 > b2 && b1 < b3 || b1 < b2 && b1 > b3)
        {
            middle2 = b1;
        }
        else if (b2 > b1 && b2 < b3 || b2 < b1 && b2 > b3)
        {
            middle2 = b2;
        }
        else
        {
            middle2 = b3;
        }

        float average = (middle1 + middle2) / 2;

        Console.WriteLine($"Среднее арифметическое средних чисел: {average}");
    }
}