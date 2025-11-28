using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 100, 95, 90, 85, 80, 75, 70, 65, 60, 55 };

        Console.WriteLine("Массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());

        int index = 0;
        while (index < massiv.Length && massiv[index] >= a)
        {
            index++;
        }

        if (index < massiv.Length)
        {
            Console.WriteLine($"Первый элемент меньше {a}: {index}");
        }
        else
        {
            Console.WriteLine($"Нет элементов меньше {a}");
        }
    }
}